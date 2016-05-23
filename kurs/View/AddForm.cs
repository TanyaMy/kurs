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
    // Форма для добавления компании.
    public partial class AddForm : Form
    {
        //Конструктор без параметров.
        public AddForm()
        {
            InitializeComponent();
        }

        // Закрытие окна по нажатию кнопки "Отмена".
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Создание новой компании и запись в нее информации, введенной в форме.
        private Company createCompanyFromForm()
        {
            Company comp = new Company();
            comp.Id = -1;
            comp.Name = nameTBox.Text;
            comp.Address = addressTBox.Text;
            comp.PhoneNumber = phoneNumberTBox.Text;
            comp.Kind = (Kind)Enum.Parse(typeof(Kind), kindCBox.Text, true);
            comp.Specialization = (Specialization)Enum.Parse(typeof(Specialization),
                specializationCBox.Text, true);
            comp.Ownership = (Ownership)Enum.Parse(typeof(Ownership),
                ownershipCBox.Text, true);
            comp.StartWork = startDTPicker.Value;
            comp.EndWork = endDTPicker.Value;

            string days = "";
            foreach (var ch in workdaysGB.Controls)
            {
                CheckBox TB = (CheckBox)ch;
                if (TB.Checked)
                    days += TB.Text + " ";
            }
            comp.WorkDays = days.Trim().Split(' ');
            string serv = "";
            foreach (var ch in servicesChLB.CheckedItems)
                serv += ch + " ";
            comp.Services = serv.Trim().Split(' ');
            return comp;
        }

        // Добавление компаниии по нажатию кнопки "ОК".
        private void okbtn_Click(object sender, EventArgs e)
        {
            CompanyCollection.AddCompany(createCompanyFromForm());
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

        //Заполнение элементов управления ComboBox значениями
        //по умолчанию при загрузке формы.
        private void AddForm_Load(object sender, EventArgs e)
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
            if (startDTPicker.Value >= endDTPicker.Value)
            {
                endDTPicker.Value = startDTPicker.Value.AddMinutes(1);
            }
        }
    }
}
