using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Library_Management_System
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        string Gender="";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check==true&&checkcnic==true&&textBox1.Text!=""&& textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!=""&&Gender!="")
            {
                Baselayer s1 = new Baselayer();
                if (MessageBox.Show("Do You want to Save Data.If Data Is Save You Can't Update It.So Be Carefully.", "Information.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    s1.modification("insert into loginTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Gender + "')");
                    this.Close();
                }
               

            }
            else
            {
                MessageBox.Show("Please Enter Correct Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool checkuser = false;
        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&&(!char.IsControl(e.KeyChar))&& (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled=true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        bool check = false;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 10)
            {
                label9.Text = "";
                check = true;
            }
            else
            {
                label9.Text = "Invalid phone number. eg 3087893347";
                check = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        bool checkcnic = false;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 13)
            {
                label10.Text = "";
                checkcnic = true;
            }
            else
            {
                label10.Text = " Invalid CNIC eg: 3660568456785";
                checkcnic = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
