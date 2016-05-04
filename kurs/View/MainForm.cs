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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutTStrMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа\nПрограмма \"Справочник потребителя\" содержит базу предприятий бытового обслуживания города. Возможен поиск предприятий по заданным параметрам. \nВыполнила: Михневич Т.К.\nст.гр ПИ-15-1\n2016", "О программе");
        }

        private void exitTStrMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTStrMenu_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
            DataBase.Read(ref dataGV);
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            bool kefir = false;

            foreach (Control control in Controls)
            {
                TextBox tb = control as TextBox;
                if (tb != null && tb.Enabled == true)
                {
                    dict.Add(tb.Name.Substring(0, tb.Name.Length - 4), tb.Text);
                    kefir = true;
                }
            }
            if (kefir)
                DataBase.Search(dict, ref dataGV);
            else 
                DataBase.Read(ref dataGV);
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dataGV[0, e.RowIndex].Value);
            CompanyForm form = new CompanyForm(DataBase.FindById((string)dataGV[0, e.RowIndex].Value));
            form.readableFields();
            form.ShowDialog();
            DataBase.Read(ref dataGV);
        }

        private void deleteTStrMenu_Click(object sender, EventArgs e)
        {
            CompanyForm form = new CompanyForm();
            form.ShowDialog();
            DataBase.Read(ref dataGV);
        }

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
                classTBox.Enabled = true;
            else
                classTBox.Enabled = false;
        }

        private void numberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (numberCheck.Checked == true)
                phoneNumberTBox.Enabled = true;
            else
                phoneNumberTBox.Enabled = false;
        }

        private void daysCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (daysCheck.Checked == true)
                workDaysTBox.Enabled = true;
            else
                workDaysTBox.Enabled = false;
        }

        private void specCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (specCheck.Checked == true)
                specializationTBox.Enabled = true;
            else
                specializationTBox.Enabled = false;
        }

        private void servicesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (servicesCheck.Checked == true)
                serviceTBox.Enabled = true;
            else
                serviceTBox.Enabled = false;
        }

        private void ownCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ownCheck.Checked == true)
                ownerTBox.Enabled = true;
            else
                ownerTBox.Enabled = false;
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
    }
}
