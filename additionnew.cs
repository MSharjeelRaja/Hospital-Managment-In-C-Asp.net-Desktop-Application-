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
    public partial class additionnew : Form
    {
        public additionnew()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog=new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog.Title = "Choose an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                Image backgroundImage = Image.FromFile(selectedImagePath);
                pictureBox1.BackgroundImage = backgroundImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
   panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
         

        }

        private void button3_Click(object sender, EventArgs e)
        { 
           
        }

        private void label13_Click(object sender, EventArgs e)
        {
            login l = new login(); 
            this.Hide();
            l.Show();
          
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
        }
    }
}
