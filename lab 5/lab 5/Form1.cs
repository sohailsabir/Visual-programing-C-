using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
       /* List<Student> ls = new List<Student>();*/
        DataTable dt = new DataTable();
        public Form1()
        {
            dt.Columns.Add("Roll no",typeof(int));
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Program",typeof(string));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  Student ob=new Student();
            ob.r = int.Parse(textBox1.Text);
            ob.n = textBox2.Text;
            ob.p = textBox3.Text;
            ls.Add(ob);
            foreach(Student a in ls){
                label5.Text = label5.Text + "\n" + "Roll no:" + a.r + "\n" + "Name:" + a.n + "\n" + "Program:" + a.p;

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            ls.Remove(ob);*/
            dt.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
