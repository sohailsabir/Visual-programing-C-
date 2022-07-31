using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudApplication
{
    public partial class Student : Form
    {
        string Gender="";
        public Student()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender="Female";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!=""&& Gender!="" &&textBox3.Text!=""&& textBox4.Text !="" && textBox5.Text !="" && textBox6.Text != "" && textBox7.Text!="")
            {
                Baselayer s1 = new Baselayer();
                s1.modification("insert into student values('"+textBox1.Text+"','"+textBox2.Text+"','"+Gender+"','"+int.Parse(textBox3.Text)+"','"+int.Parse(textBox4.Text)+"','"+int.Parse(textBox5.Text)+"','"+textBox6.Text+"','"+textBox7.Text+"')");
                MessageBox.Show("Data Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Feild Not Allowed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            

            
        }
    }
}
