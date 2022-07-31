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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check==true&& checkmail==true&&textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text!="")
            {
                Baselayer s2 = new Baselayer();
                s2.modification("insert into Students values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +textBox5.Text + "','" +textBox6.Text + "')");
                MessageBox.Show("Data Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            else
            {
                MessageBox.Show("Please provide Correct Information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        bool check= false;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
               if(textBox5.Text.Length==10)
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
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (!char.IsDigit(e.KeyChar))&&(!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }
        bool checkmail = false;
        private void textBox6_Leave(object sender, EventArgs e)
        {
            string pattern="^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(textBox6.Text,pattern))
            {
                errorProvider1.Clear();
                checkmail = true;

            }
            else { errorProvider1.SetError(this.textBox6, "please provide valid mail address");
            bool checkmail = false;

            return;
            }
        }
    }
}
