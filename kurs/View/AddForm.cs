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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(Company comp)
        {
            InitializeComponent();
            fillFields(comp);
        }

        private void fillFields(Company comp)
        {
            nameTBox.Text = comp.Name;
            phoneNumberTBox.Text = comp.PhoneNumber;
            serviceTBox.Text = String.Join(" ", comp.Services);
            addressTBox.Text = comp.Address;
            workDaysTBox.Text = String.Join(" ", comp.WorkDays);
            classTBox.Text = comp.Class;
            ownerTBox.Text = comp.Ownership;
            specializationTBox.Text = comp.Specialization;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Company company = new Company()
            {
                Name = nameTBox.Text,
                Address = addressTBox.Text,
                PhoneNumber = phoneNumberTBox.Text,
                Class = classTBox.Text,
                Specialization = specializationTBox.Text,
                Ownership = ownerTBox.Text,
                Services = serviceTBox.Text.Trim().Split(' '),
                WorkDays = workDaysTBox.Text.Trim().Split(' ')
            };
            DataBase.Delete(company);
            this.Close();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Company company = new Company()
            {
                Id = -1,
                Name = nameTBox.Text,
                Address = addressTBox.Text,
                PhoneNumber = phoneNumberTBox.Text,
                Class = classTBox.Text,
                Specialization = specializationTBox.Text,
                Ownership = ownerTBox.Text,
                Services = serviceTBox.Text.Trim().Split(' '),
                WorkDays = workDaysTBox.Text.Trim().Split(' ')
            };
            DataBase.Add(company);
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
            startWorkNUD.Value = 0;
            endWorkNUD.Value = 0;
        }
    }
}
