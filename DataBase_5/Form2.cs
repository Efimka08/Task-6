using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ratingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ratingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.efim_DatabaseDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "efim_DatabaseDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.efim_DatabaseDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "efim_DatabaseDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.ratingTableAdapter.Fill(this.efim_DatabaseDataSet.Rating);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ratingTableAdapter.FillBy(this.efim_DatabaseDataSet.Rating, groupToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
