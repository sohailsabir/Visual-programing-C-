using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhammad_Sohail
{
    public partial class Form1 : Form
    {
        double a, b, r;
        char op;
        public void cal(char op1)
        {
            switch(op1)
            {
                case '+':
                    r = a + b;
                    break;
                case '-':
                    r = a - b;
                    break;
                case 'X':
                    r = a * b;
                    break;
                case '/':
                    r = a / b;
                    break;
                case '%':
                    r = a % b;
                    break;

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circularButton9_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton9.Text;
            button3.Text = button3.Text + circularButton9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void circularButton10_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton10.Text;
            button3.Text = button3.Text + circularButton10.Text;
        }

        private void circularButton11_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton11.Text;
            button3.Text = button3.Text + circularButton11.Text;
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton5.Text;
            button3.Text = button3.Text + circularButton5.Text;
        }

        private void circularButton6_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton6.Text;
            button3.Text = button3.Text + circularButton6.Text;
        }

        private void circularButton7_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton7.Text;
            button3.Text = button3.Text + circularButton7.Text;
        }

        private void circularButton1_Click_1(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton1.Text;
            button3.Text = button3.Text + circularButton1.Text;
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton4.Text;
            button3.Text = button3.Text + circularButton4.Text;
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton3.Text;
            button3.Text = button3.Text + circularButton3.Text;
        }

        private void circularButton13_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text + circularButton13.Text;
            button3.Text = button3.Text + circularButton13.Text;
        }

        private void circularButton8_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(button2.Text);
            button3.Text = button3.Text + circularButton8.Text;
            button2.Text = "";
            op = '+';
        }

        private void circularButton2_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(button2.Text);
            button3.Text = button3.Text + circularButton2.Text;
            button2.Text = "";
            op = '-';
        }

        private void circularButton17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(button2.Text);
            button2.Text = "";
            button3.Text = button3.Text + circularButton17.Text;
            op = 'X';
        }

        private void circularButton16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(button2.Text);
            button2.Text = "";
            button3.Text = button3.Text + circularButton16.Text;
            op = '/';
        }

        private void circularButton15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(button2.Text);
            button2.Text = "";
            button3.Text = button3.Text + circularButton15.Text;
            op = '%';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(button2.Text);
            cal(op);
            button2.Text = r.ToString();
            button3.Text = "";
        }

        private void circularButton12_Click(object sender, EventArgs e)
        {
            button3.Text = "";
            button2.Text = "";
        }

        private void circularButton14_Click(object sender, EventArgs e)
        {
           
            int length = button2.Text.Length;
            int c=0;
            for(int i=0;i<=length-1;i++)
            {
                if(button2.Text[i]=='.')
                {
                    c = 1;
                    break;
                }
                
            }
            if(c==0)
            {
                button2.Text = button2.Text + circularButton14.Text;
                button3.Text = button3.Text + circularButton14.Text;
            }
        }
    }
}
