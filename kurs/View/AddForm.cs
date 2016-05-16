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
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Company SetInformationFromForm()
        {
            Company comp = new Company();
            comp.Id = -1;
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

        private void okbtn_Click(object sender, EventArgs e)
        {
            DataBase.Add(SetInformationFromForm());
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
                else if (c is ComboBox)
                    ((ComboBox)c).Text = null;
            foreach (CheckBox ch in workdaysGB.Controls)
                ch.Checked = false;
            startDTPicker.Value = Convert.ToDateTime("01/01/1800 " + "00:00" + ":00.00"); 
            endDTPicker.Value = Convert.ToDateTime("01/01/1800 " + "00:01" + ":00.00");                    
                for (int i = 0; i < servicesChLB.Items.Count; i++)                   
                        servicesChLB.SetItemChecked(i, false);
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

            startDTPicker.MaxDate = endValue.AddMinutes(-1);
        }

        private void startDTPicker_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
