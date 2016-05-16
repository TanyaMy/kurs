using kurs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IDictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var control in Controls)
            {
                TextBox tb = null;
                ComboBox cb = null;

                if (control as TextBox != null)
                    tb = control as TextBox;
                else if (control as ComboBox != null)
                    cb = control as ComboBox;

                if (tb != null && tb.Enabled)
                    dict.Add(tb.Name.Substring(0, tb.Name.Length - 4), tb.Text.ToLower());
                else if (cb != null && cb.Enabled)
                    dict.Add(cb.Name.Substring(0, cb.Name.Length - 4), cb.SelectedItem.ToString().ToLower());
            }

            if (workdaysGB.Enabled)
            {
                dict.Add("workDays", "");
                foreach (var tmp in workdaysGB.Controls)
                {
                    var ch = (CheckBox)tmp;
                    if (ch.Checked)
                        dict["workDays"] += ch.Text + " ";
                }
                if (dict["workDays"].Trim().Length == 0)
                    dict.Remove("workDays");
            }

            if (servicesChLB.Enabled)
            {
                dict.Add("services", "");
                foreach (var ch in servicesChLB.CheckedItems)
                    dict["services"] += ch + " ";
                if (dict["services"].Trim().Length == 0)
                    dict.Remove("services");
            }

            if (startDTPicker.Enabled)
                dict.Add("workTime", startDTPicker.Value.Hour + ":" + startDTPicker.Value.Minute + 
                    " " + endDTPicker.Value.Hour + ":" + endDTPicker.Value.Minute);

            if (dict.Any())
                DataBase.Search(dict, ref dataGV);
            else
                DataBase.Read(ref dataGV);
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)// Вызов формы с информацией по выбранной компании по двойному щелчку по строке в DataGridView
        {
            if (e.RowIndex < 0) return;
            int ID = Convert.ToInt32(dataGV[0, e.RowIndex].Value);
            CompanyForm form = new CompanyForm(DataBase.FindById((string)dataGV[0, e.RowIndex].Value));
            form.readableFields();
            form.ShowDialog();            
        }


        #region// Проверка, был ли выбран Чекбокс для параметра поиска. Если да, то поле становится активным. Надо бы все это сделать одним методом

        private void nameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheck.Checked == true)
                nameTBox.Enabled = true;
            else
                nameTBox.Enabled = false;
        }

        private void addressCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (addressCheck.Checked == true)
                addressTBox.Enabled = true;
            else
                addressTBox.Enabled = false;
        }

        private void classCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (classCheck.Checked == true)
                classCBox.Enabled = true;
            else
                classCBox.Enabled = false;
        }

        private void numberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (numberCheck.Checked == true)
                phoneNumberTBox.Enabled = true;
            else
                phoneNumberTBox.Enabled = false;
        }

        private void specCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (specCheck.Checked == true)
                specializationCBox.Enabled = true;
            else
                specializationCBox.Enabled = false;
        }

        private void ownCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ownCheck.Checked == true)
                ownershipCBox.Enabled = true;
            else
                ownershipCBox.Enabled = false;
        }

       
        private void workDaysCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            if (workDaysCheck.Checked == true)
            {
                foreach (var tmp in workdaysGB.Controls)
                {
                    var ch = (CheckBox)tmp;
                    ch.Enabled = true;
                }
            }
            else {
                foreach (var tmp in workdaysGB.Controls)
                {
                    var ch = (CheckBox)tmp;
                    ch.Enabled = false;
                }
            }
        }

        private void servicesCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (servicesCheck.Checked)
                servicesChLB.Enabled = true;
            else
                servicesChLB.Enabled = false;
        }

        private void timeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(timeCheck.Checked == true)
            {
                startDTPicker.Enabled = true;
                endDTPicker.Enabled = true;
            }
            else
            {
                startDTPicker.Enabled = false;
                endDTPicker.Enabled = false;
            }

        }

        private void endDTPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime endValue = endDTPicker.Value;
            if (startDTPicker.MaxDate >= endDTPicker.Value)
            {
                if (endValue.Minute > 0)
                    endValue.AddMinutes(-1);
                else {
                    endValue.AddMinutes(59);
                    endValue.AddHours(-1);
                }
            }
            else 
                endValue.AddMinutes(-1);

            startDTPicker.MaxDate = endValue;
        }
        #endregion


        private void updatepBox_Click(object sender, EventArgs e)// Обновление DataGridView по нажатию кнопки
        {
            findbtn_Click(sender, e);
        }

    }
}
