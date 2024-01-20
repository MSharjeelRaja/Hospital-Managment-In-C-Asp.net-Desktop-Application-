using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisnesslay;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospitaldesktop
{
    public partial class login : Form
    {
       

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            panel2.Hide(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter UserName to Login", "Login Authetication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Enter Password to Login", "Login Authetication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox2.Focus();
                        return;
                    }
                    else
                    {
                        logic l = new logic();
                        String g = l.Login(textBox1.Text, textBox2.Text);
                        if (g != null)
                        {
                            if (g.Equals("DR"))
                            {
                                drdash dr = new drdash();
                                dr.Show();
                                this.Hide();

                            }
                            else if (g.Equals("Patient"))
                            {


                                this.Hide();
                            }
                            else if (g.Equals("Admin"))
                            {


                                this.Hide();
                            }
                            else if (g.Equals("Pharmacy"))
                            {


                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Are Not Authorized to Use System", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                            textBox1.Focus();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBox3.Text == "")
                {
                    MessageBox.Show("Enter UserName to REset", "Login Authetication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Enter Password to Reset", "Login Authetication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                else
                {
                    if (textBox5.Text == "")
                    {
                        MessageBox.Show("Confirm Password to Reset", "Login Authetication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox2.Focus();
                        return;
                    }

                    else if (textBox5.Text == textBox4.Text)
                    {
                        logic l = new logic();
                        String g = l.resetpass(textBox3.Text, textBox4.Text);
                        if (g != null)
                        {
                            if (g.Equals("DR"))
                            {

                                panel1.Show();
                                panel2.Hide();

                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Cant find");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Pass not match");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //additionnew a = new additionnew();
            //a.Show();
            panel1.Hide();
            panel2.Show();
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
