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
    public partial class AddForm : Form// Форма для добавления компании
    {
        public AddForm()//Конструктор без параметров
        {
            InitializeComponent();
        }
        private void cancelbtn_Click(object sender, EventArgs e)// Закрытие окна по нажатию кнопки "Отмена"
        {
            Close();
        }
        private Company createCompanyFromForm()//Создание новой компании и запись в нее информации, введенной в форме.
        {
            Company comp = new Company();
            comp.Id = -1;
            comp.Name = nameTBox.Text;
            comp.Address = addressTBox.Text;
            comp.PhoneNumber = phoneNumberTBox.Text;
            comp.Kind = (Kind)Enum.Parse(typeof(Kind), kindCBox.Text, true);
            comp.Specialization = (Specialization)Enum.Parse(typeof(Specialization), specializationCBox.Text, true);
            comp.Ownership = (Ownership)Enum.Parse(typeof(Ownership), ownershipCBox.Text, true);
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

        private void okbtn_Click(object sender, EventArgs e)// Добавление компаниии по нажатию кнопки "ОК"
        {
            CompanyCollection.AddCompany(createCompanyFromForm());
        }

        private void resetbtn_Click(object sender, EventArgs e)//Сброс введенной информации
        {
            ResetFields();
        }
        public void ResetFields()//сбрасывает значение всех полей формы
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
                else if (c is ComboBox)
                    ((ComboBox)c).Text = null;
                else if (c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                    foreach (CheckBox ch in gb.Controls)
                        ch.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Value = Convert.ToDateTime("01/01/1800 " + "00:00" + ":00.00");
                }
                else if (c is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)c;
                    for (int i = 0; i < clb.Items.Count; i++)
                        clb.SetItemChecked(i, false);
                }
        }
    }
}
