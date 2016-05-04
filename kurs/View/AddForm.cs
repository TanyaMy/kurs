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

        private Company SetInformationFromForm(Company comp)
        {
                comp.Name = nameTBox.Text;
                comp.Address = addressTBox.Text;
                comp.PhoneNumber = phoneNumberTBox.Text;
                comp.Class = classTBox.Text;
                comp.Specialization = specializationTBox.Text;
                comp.Ownership = ownerTBox.Text;
                comp.Services = serviceTBox.Text.Trim().Split(' ');
                comp.WorkDays = workDaysTBox.Text.Trim().Split(' ');
                return comp;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Id = -1;
            SetInformationFromForm(company);
            DataBase.Add(company);
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
        }
    }
}
