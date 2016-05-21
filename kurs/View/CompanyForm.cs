using kurs.Model;
using System;
using System.Windows.Forms;

namespace kurs.View
{
    // Форма для просмотра и изменения компании с заполненными полями.
    public partial class CompanyForm : Form
    {
        // Конструктор без параметров.
        public CompanyForm()
        {
            InitializeComponent();
        }

        //Конструктор с параметром. Принимает компанию и заполняет поля
        //формы информацией об этой компании.
        public CompanyForm(Company comp)
        {
            InitializeComponent();
            fillFields(comp);
        }      
       
        //Создание новой компании и запись в нее информации, введенной в форме.
        private Company createCompanyFromForm()
        {
            Company comp = new Company();
            comp.Id = Convert.ToInt32(IDlbl.Text);
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

        //Принимает компанию и заполняет поля формы информацией об этой компании.
        private void fillFields(Company comp)
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
                    if (arr[i].ToString().Equals(s, 
                        StringComparison.OrdinalIgnoreCase))
                        servicesChLB.SetItemChecked(i, true);
        }

        // Закрытие окна по нажатию кнопки "Отмена".
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Закрытие окна по нажатию кнопки "Отмена".
        private void okbtn_Click(object sender, EventArgs e)
        {
            var comp = createCompanyFromForm();
            CompanyCollection.ChangeCompany(comp.Id, comp);
        }

        // Делает поля доступными для записи по нажатию кнопки "Изменить".
        private void changebtn_Click(object sender, EventArgs e)
        {
            Writable(true);
        }

        /// <summary>
        /// Делает поля формы доступными только для чтения и для записи
        /// в зависимости от введенного параметра - булевого значения.
        /// </summary>
        /// <param name="verif"></param>
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
    }
}
