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
        }

       

        private void findbtn_Click(object sender, EventArgs e)
        {
            DataBase.Read(ref dataGV);
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dataGV[0, e.RowIndex].Value);
            CompanyForm form = new CompanyForm(DataBase.FindById((string)dataGV[0, e.RowIndex].Value));
            form.readableFields();
            form.ShowDialog();
        }

        private void deleteTStrMenu_Click(object sender, EventArgs e)
        {
            CompanyForm form = new CompanyForm();
            form.ShowDialog();
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
