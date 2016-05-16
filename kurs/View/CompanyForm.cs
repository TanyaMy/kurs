using kurs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace kurs.View
{
    public partial class CompanyForm : Form// Форма для удаления и изменения компании с заполненными полями
    {
        
        public CompanyForm()// Конструктор без параметров
        {
            InitializeComponent();
        }
        public CompanyForm(Company comp)// Конструктор с параметром. Принимает компанию и заполняет поля формы информацией об этой компании
        {
            InitializeComponent();
            fillFields(comp);
        }

        public void readableFields()// Делает все поля формы доступными только для чтения
        {
            foreach (var element in Controls)
            {
                if (element is TextBox)
                {
                    TextBox tb = (TextBox)element;
                    tb.ReadOnly = true;
                }
                else if (element is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)element;
                    dtp.Enabled = false;
                }
                else if (element is ComboBox)
                {
                    ComboBox cb = (ComboBox)element;
                    cb.Enabled = false;
                }
                else if (element is CheckBox)
                {
                    CheckBox cb = (CheckBox)element;
                    cb.Enabled = false;
                }
            }
            servicesChLB.Enabled = false;
            foreach (var tmp in workdaysGB.Controls)
            {
                var ch = (CheckBox)tmp;
                ch.Enabled = false;
            }
        }

        public void writableFields()// Делает все поля формы доступными для записи
        {
            foreach (var element in Controls)
            {
                if (element is TextBox)
                {
                    TextBox tb = (TextBox)element;
                    tb.ReadOnly = false;
                }
                else if (element is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)element;
                    dtp.Enabled = true;
                }
                else if (element is ComboBox)
                {
                    ComboBox cb = (ComboBox)element;
                    cb.Enabled = true;
                }
                else if (element is CheckBox)
                {
                    CheckBox cb = (CheckBox)element;
                    cb.Enabled = true;
                }
            }
            foreach (var tmp in workdaysGB.Controls)
            {
                var ch = (CheckBox)tmp;
                ch.Enabled = true;
            }
            servicesChLB.Enabled = true;
        }

        private void fillFields(Company comp)//Принимает компанию и заполняет поля формы информацией об этой компании
        {
            IDlbl.Text = "" + comp.Id;
            nameTBox.Text = comp.Name;
            phoneNumberTBox.Text = comp.PhoneNumber;
            addressTBox.Text = comp.Address;
            classCBox.Text = comp.Class;
            ownershipCBox.Text = comp.Ownership;
            specializationCBox.Text = comp.Specialization;
            endDTPicker.Value = comp.EndWork;
            startDTPicker.Value = comp.StartWork;


            foreach (var s in comp.WorkDays)
                foreach(var el in workdaysGB.Controls)
                {
                    var El = el as CheckBox;
                    if (El.Text.Equals(s, StringComparison.OrdinalIgnoreCase))
                        El.Checked = true;
                }           

            var arr = servicesChLB.Items;
            foreach (var s in comp.Services)
                for (int i = 0; i < servicesChLB.Items.Count; i++)
                    if (arr[i].ToString().Equals(s, StringComparison.OrdinalIgnoreCase))
                        servicesChLB.SetItemChecked(i, true);
        }
        private Company SetInformationFromForm()//Создание новой компании и записьв нее информации, введенной в форме.
        {
            Company comp = new Company();
            comp.Id = Convert.ToInt32(IDlbl.Text);
            comp.Name = nameTBox.Text;
            comp.Address = addressTBox.Text;
            comp.PhoneNumber = phoneNumberTBox.Text;
            comp.Class = classCBox.Text;
            comp.Specialization = specializationCBox.Text;
            comp.Ownership = ownershipCBox.Text;
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

        private void cancelbtn_Click(object sender, EventArgs e)// Закрытие окна по нажатию кнопки "Отмена"
        {
            Close();
        }

        private void okbtn_Click(object sender, EventArgs e)// Изменение компании по нажатию кнопки "ОК"
        {            
            DataBase.Change(SetInformationFromForm());
        }

        private void deletebtn_Click(object sender, EventArgs e)// Удаление информации по нажатию кнопки "Удалить"
        {
            DataBase.Delete(Convert.ToInt32(IDlbl.Text));
            Close();
        }

        private void Changebtn_Click(object sender, EventArgs e)// Делает поля доступными для записи
        {
            writableFields();
        }       

        private void endDTPicker_ValueChanged(object sender, EventArgs e)// Проверка, чтоб начало рабочего дня не было позже, чем конец
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
            startDTPicker.MaxDate = endValue.AddMinutes(-1);
        }
    }
}
