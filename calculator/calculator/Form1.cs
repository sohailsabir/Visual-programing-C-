using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0,b=0,r=0;
        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(r.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar2.Value);
        }
    }
}
