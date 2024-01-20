using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitaldesktop
{
    public partial class drdash : Form
    {
        public drdash()
        {
            InitializeComponent();
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetDefaultCellStyles()
        {
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

            DataGridViewCellStyle highlightCellStyle = new DataGridViewCellStyle();
            highlightCellStyle.BackColor = Color.Red;

            DataGridViewCellStyle currencyCellStyle = new DataGridViewCellStyle();
            currencyCellStyle.Format = "C";
            currencyCellStyle.ForeColor = Color.Green;

            this.dataGridView1.Rows[3].DefaultCellStyle = highlightCellStyle;
            this.dataGridView1.Rows[8].DefaultCellStyle = highlightCellStyle;
            this.dataGridView1.Columns["UnitPrice"].DefaultCellStyle =
                currencyCellStyle;
            this.dataGridView1.Columns["TotalPrice"].DefaultCellStyle =
                currencyCellStyle;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
