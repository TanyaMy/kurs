using kurs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace kurs.View
{
    public partial class MainForm : Form// Форма для поиска по различным параметрам, для вызова форм
                                        //для изменения, удаления и добавления компании.
    {
        public MainForm()// Конструктор без параметров
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindListToDataGridView(CompanyCollection.CompaniesList);
        }

        /// <summary>
        /// Информация о программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutTStrMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа\nПрограмма \"Справочник потребителя\" содержит базу предприятий бытового обслуживания города. Возможен поиск предприятий по заданным параметрам. \nВыполнила: Михневич Т.К.\nст.гр ПИ-15-1\n2016", "О программе");
        }

        private void exitTStrMenu_Click(object sender, EventArgs e)// Зактрытие формы по нажатию "Выход"
        {
            Close();
        }

        private void addTStrMenu_Click(object sender, EventArgs e)// Открытие формы для добавления компании по нажатию "Добавить"
        {
            AddForm form = new AddForm();
            form.ShowDialog();            
        }

        private void findbtn_Click(object sender, EventArgs e)// Формирования словаря "ключ" - "значение" по нажатию кнопки "Найти" для поиска в XML-документе 
        {
            var comp = GetCompanyForSearch();
            var collection = CompanyCollection.Search(comp);
            BindListToDataGridView(collection);
        }
        public int ToInt(dynamic num)
        {
            return Convert.ToInt32(num);
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)// Вызов формы с информацией по выбранной компании по двойному щелчку по строке в DataGridView
        {
            if (e.RowIndex < 0) return;
            int ID = Convert.ToInt32(dataGV[0, e.RowIndex].Value);
            CompanyForm form = new CompanyForm(CompanyCollection.GetCompanyById(Convert.ToInt32(dataGV[0, e.RowIndex].Value)));
            form.Writable(false);
            form.ShowDialog();            
        }

        private void updatepBox_Click(object sender, EventArgs e)// Обновление DataGridView по нажатию кнопки
        {
            BindListToDataGridView(CompanyCollection.CompaniesList);
        }

        private void saveTStrMenu_Click(object sender, EventArgs e)
        {
            DataBase.SaveToFile(CompanyCollection.CompaniesList);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.SaveToFile(CompanyCollection.CompaniesList);
        }

        private void dataGV_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            dataGV[e.ColumnIndex, e.RowIndex].Selected = true;
            dataGV.ContextMenuStrip.Show(new System.Drawing.Point());

        }

        private void deleteTSM_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление компании", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CompanyCollection.DeleteCompany(Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value));
            }
        }

        private void changeTSM_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value);

            CompanyForm form = new CompanyForm
                (CompanyCollection.GetCompanyById
                    (Convert.ToInt32(dataGV[0, dataGV.SelectedCells[0].ColumnIndex].Value)));

            form.Writable(false);
            form.ShowDialog();
        }

        private void showTSM_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value);

            CompanyForm form = new CompanyForm
                (CompanyCollection.GetCompanyById
                    (Convert.ToInt32(dataGV[0, dataGV.SelectedRows[0].Index].Value)));

            form.Writable(false);
            form.ShowDialog();
        }

        private Company GetCompanyForSearch()
        {
            var company = new Company()
            {
                Name = nameTBox.Text,
                Address = addressTBox.Text,
                PhoneNumber = phoneNumberTBox.Text,
                Kind = (Kind)Enum.Parse(typeof(Kind), kindCBox.Text, true),
                Specialization = (Specialization)Enum.Parse(typeof(Specialization), specializationCBox.Text, true),
                Ownership = (Ownership)Enum.Parse(typeof(Ownership), ownershipCBox.Text, true),
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

        private void BindListToDataGridView(BindingList<Company> list)
        {
            var bindingList = list;
            var source = new BindingSource(bindingList, null);
            dataGV.DataSource = source;
        }
    }
}
