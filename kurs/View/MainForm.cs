using kurs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace kurs.View
{
    // Форма для поиска по различным параметрам, вызова форм
    //просмотра/изменения/добавления компании.
    public partial class MainForm : Form
    {
        // Конструктор без параметров.
        public MainForm()
        {
            InitializeComponent();
        }

        //Заполнение элементов управления ComboBox значениями
        //по умолчанию при загрузке формы.
        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox combo = (ComboBox)c;
                    combo.SelectedIndex = 0;
                }
            }

        }
        
        //Информация о программе в MessagaBox при выборе
        //в меню "Помощь -> О программе".       
        private void aboutTStrMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа\nПрограмма \"Справочник потребителя\"" + 
                " содержит базу предприятий бытового обслуживания города. Возможен" +
                " поиск предприятий по заданным параметрам. \nВыполнила:" + 
                " Михневич Т.К.\nст.гр ПИ-15-1\n2016", "О программе");
        }

        // Зактрытие формы по нажатию "Выход".
        private void exitTStrMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Открытие формы для добавления компании
        //по выбору в меню "Правка -> Добавить".
        private void addTStrMenu_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
            var collection = CompanyCollection.Search(getCompanyForSearch());
            bindListToDataGridView(collection); 
        }

        /// <summary>
        /// По нажатию кнопки "Найти" вызов метода создания экземпляра класса
        /// Company с заполненной формы для поиска, затем вызов метода поиска
        /// компаний, удовлетворяющих критериям поиска
        /// и заполнение DataGridView информацией о найденных компаниях.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findbtn_Click(object sender, EventArgs e)
        {
            var comp = getCompanyForSearch();
            var collection = CompanyCollection.Search(comp);
            bindListToDataGridView(collection);
            if (collection.Count == 0)
            {
                DialogResult dialogRes =
                   MessageBox.Show("Предприятий по заданным параметрам не найдено.",
                   "Поиск", MessageBoxButtons.OK);
                return;
            }
        }        

        // Вызов формы с информацией по выбранной компании
        //по двойному щелчку по строке в DataGridView.
        private void dataGV_CellDoubleClick(object sender, 
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int ID = Convert.ToInt32(dataGV[0, e.RowIndex].Value);
            CompanyForm form = 
                new CompanyForm(CompanyCollection.
                GetCompanyById(Convert.ToInt32(dataGV[0, e.RowIndex].Value)));
            form.Writable(false);
            form.ShowDialog();
            var collection = CompanyCollection.Search(getCompanyForSearch());
            bindListToDataGridView(collection);
        }

        //Сохранение изменений в документе при выборе в меню "Файл -> Сохранить".
        private void saveTStrMenu_Click(object sender, EventArgs e)
        {
            DataBase.SaveToFile(CompanyCollection.CompaniesList);
        }

        //Сохранение изменений в документе при закрытии формы.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.SaveToFile(CompanyCollection.CompaniesList);
        }

        //Вызов контекстного меню по событию "Нажатие правой клавишей
        //мыши по выбранной компании в DataGridView"
        private void dataGV_CellContextMenuStripNeeded(object sender, 
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dataGV[e.ColumnIndex, e.RowIndex].Selected = true;
            dataGV.ContextMenuStrip.Show(new System.Drawing.Point());
        }

        //Удаление выбранной компании в DataGridView по выбору
        //в контекстном меню "Удалить".
        private void deleteTSM_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(dataGV[0, 
                    dataGV.SelectedRows[0].Index].Value);
                DialogResult dialogResult = MessageBox.Show("Вы уверены, " +
                    "что хотите удалить " + dataGV[1,
                    dataGV.SelectedRows[0].Index].Value + " ? ",
               "Удаление предприятия", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CompanyCollection.DeleteCompany
                       (Convert.ToInt32(dataGV[0, 
                       dataGV.SelectedRows[0].Index].Value));                    
                    var collection = CompanyCollection.
                        Search(getCompanyForSearch());
                    bindListToDataGridView(collection);
                }               
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogRes =
                    MessageBox.Show("Выберите предприятие для удаления.",
                    "Удаление предприятия", MessageBoxButtons.OK);
                return;
            }
             catch (KeyNotFoundException)
            {
                DialogResult dialogRes =
                    MessageBox.Show("Выберите предприятие для удаления.",
                    "Удаление предприятия", MessageBoxButtons.OK);
                return;
            }
           
        }

        //Изменение выбранной компании в DataGridView по выбору в контекстном меню
        //"Изменить". Вызов формы для внесения изменений в выбранную компанию.
        private void changeTSM_Click(object sender, EventArgs e)
        {
            try {
                int ID = Convert.ToInt32(dataGV[0, 
                    dataGV.SelectedRows[0].Index].Value);
               CompanyForm form = new CompanyForm
               (CompanyCollection.GetCompanyById(ID));

                form.Writable(false);
                form.ShowDialog();
                var comp = getCompanyForSearch();
                var collection = CompanyCollection.Search(comp);
                bindListToDataGridView(collection);
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Выберите предприятие для изменения.",
                    "Изменение предприятия", MessageBoxButtons.OK);
                return;
            }
            catch (KeyNotFoundException)
            {
                DialogResult dialogResult =
                   MessageBox.Show("Выберите предприятие для изменения.",
                   "Изменение предприятия", MessageBoxButtons.OK);
                return;
            }

        }

        //Показ информации о выбранной компании в DataGridView по
        //выбору в контекстном меню "Просмотреть".
        private void showTSM_Click(object sender, EventArgs e)
        {
            try {
                int ID = Convert.ToInt32(dataGV[0,
                    dataGV.SelectedRows[0].Index].Value);
                CompanyForm form = new CompanyForm
                    (CompanyCollection.GetCompanyById
                        (Convert.ToInt32(dataGV[0,
                        dataGV.SelectedRows[0].Index].Value)));
                form.Writable(false);
                form.ShowDialog();
                var collection = CompanyCollection.Search(getCompanyForSearch());
                bindListToDataGridView(collection);
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Выберите предприятие для просмотра.",
                    "Просмотр предприятия", MessageBoxButtons.OK);
                return;
            }
        }

        //Создание объекта Company с информацией, введенной в форме для поиска.
        private Company getCompanyForSearch()
        {
            var company = new Company()
            {
                Name = nameTBox.Text,
                Address = addressTBox.Text,
                PhoneNumber = phoneNumberTBox.Text,
                Kind = (Kind)Enum.Parse(typeof(Kind), kindCBox.Text, true),
                Specialization = (Specialization)Enum.Parse(typeof(Specialization),
                    specializationCBox.Text, true),
                Ownership = (Ownership)Enum.Parse(typeof(Ownership),
                    ownershipCBox.Text, true),
                StartWork = startDTPicker.Value,
                EndWork = endDTPicker.Value
            };

            string days = "";
            foreach (var ch in workdaysGB.Controls)
            {
                CheckBox TB = (CheckBox)ch;
                if (TB.Checked)
                    days += TB.Text + " ";
            }
            company.WorkDays = days.Trim().Split(' ');
            string serv = "";
            foreach (var ch in servicesChLB.CheckedItems)
                serv += ch + " ";
            company.Services = serv.Trim().Split(' ');
            return company;
        }

        //Привязка списка компаний к DataGridView.
        private void bindListToDataGridView(BindingList<Company> list)
        {
            var bindingList = list;
            var source = new BindingSource(bindingList, null);
            dataGV.DataSource = source;
        }

        //Сброс введенной в форме информации.
        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = "";
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                else if (c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                    foreach (CheckBox ch in gb.Controls)
                        ch.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    if (dtp.Name == "startDTPicker")
                        dtp.Value = 
                            Convert.ToDateTime("01/01/1800 " + "00:00" + ":00.00");
                    else if (dtp.Name == "endDTPicker")
                        dtp.Value = 
                            Convert.ToDateTime("01/01/1800 " + "23:59" + ":00.00");

                }
                else if (c is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)c;
                    for (int i = 0; i < clb.Items.Count; i++)
                        clb.SetItemChecked(i, false);
                }
        }

        //Проверка на правильность введенной даты 
        //(дата начала рабочего дня не должна опережать дату завершения рабочего дня) 
        //по событию "Изменение даты начала рабочего дня".
        private void startDTPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startValue = endDTPicker.Value;
            startDTPicker.MaxDate = startValue.AddMinutes(-1); ;
            if (startDTPicker.MaxDate >= endDTPicker.Value)
            {
                if (startValue.Minute > 0)
                    startValue.AddMinutes(-1);
                else {
                    startValue.AddMinutes(59);
                    startValue.AddHours(-1);
                }
            }
            else
                startValue.AddMinutes(-1);
        }

        //Проверка на правильность введенной даты 
        //(дата начала рабочего дня не должна опережать дату завершения рабочего дня)
        //по событию "Изменение даты конца рабочего дня".
        private void endDTPicker_ValueChanged(object sender, EventArgs e)
        {
            if(startDTPicker.Value >= endDTPicker.Value)
            {
                endDTPicker.Value = startDTPicker.Value.AddMinutes(1);
            }
        }
    }
}
