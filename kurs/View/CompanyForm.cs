using kurs.Model;
using System;
using System.Windows.Forms;

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
       
        private Company createCompanyFromForm()//Создание новой компании и запись в нее информации, введенной в форме.
        {
            Company comp = new Company();
            comp.Id = Convert.ToInt32(IDlbl.Text);
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
        private void fillFields(Company comp)//Принимает компанию и заполняет поля формы информацией об этой компании
        {
            IDlbl.Text = "" + comp.Id;
            nameTBox.Text = comp.Name;
            phoneNumberTBox.Text = comp.PhoneNumber;
            addressTBox.Text = comp.Address;
            kindCBox.Text = comp.Kind.ToString();
            ownershipCBox.Text = comp.Ownership.ToString();
            specializationCBox.Text = comp.Specialization.ToString();
            endDTPicker.Value = comp.EndWork;
            startDTPicker.Value = comp.StartWork;


            foreach (var s in comp.WorkDays)
                foreach (var el in workdaysGB.Controls)
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
        private void cancelbtn_Click(object sender, EventArgs e)// Закрытие окна по нажатию кнопки "Отмена"
        {
            Close();
        }

        private void okbtn_Click(object sender, EventArgs e)// Изменение компании по нажатию кнопки "ОК"
        {
            var comp = createCompanyFromForm();
            CompanyCollection.ChangeCompany(comp.Id, comp);
        }

        private void deletebtn_Click(object sender, EventArgs e)// Удаление информации по нажатию кнопки "Удалить"
        {
            CompanyCollection.DeleteCompany(Convert.ToInt32(IDlbl.Text));
            Close();
        }

        private void changebtn_Click(object sender, EventArgs e)// Делает поля доступными для записи
        {
            Writable(true);
        }
        public void Writable(bool verif)
        {
            foreach (var element in Controls)
            {
                if (element is TextBox)
                {
                    TextBox tb = (TextBox)element;
                    tb.ReadOnly = !verif;
                }
                else if (element is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)element;
                    dtp.Enabled = verif;
                }
                else if (element is ComboBox)
                {
                    ComboBox cb = (ComboBox)element;
                    cb.Enabled = verif;
                }
                else if (element is CheckBox)
                {
                    CheckBox cb = (CheckBox)element;
                    cb.Enabled = verif;
                }
                else if (element is CheckedListBox)
                {
                    CheckedListBox cb = (CheckedListBox)element;
                    cb.Enabled = verif;
                }
                else if (element is GroupBox)
                {
                    GroupBox gb = (GroupBox)element;
                    foreach (var tmp in gb.Controls)
                    {
                        var ch = (CheckBox)tmp;
                        ch.Enabled = verif;
                    }
                }
            }
        }
    }
}
