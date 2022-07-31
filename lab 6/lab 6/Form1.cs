using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab_6
{
    public partial class Form1 : Form
    {
        Baselayer e = new Baselayer();
        public Form1()
        {

            InitializeComponent();
            
           dataGridView1.DataSource= e.Displayinfo("select * from information");

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.studentDataSet.information);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baselayer i = new Baselayer();
            i.Modificationinfo("insert into information values('"+int.Parse(textBox1.Text)+"','"+textBox2.Text+"','"+comboBox1.Text+"')");
          dataGridView1.DataSource=  i.Displayinfo("select * from information");
           
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baselayer u = new Baselayer();
            u.Modificationinfo("update information set name='"+textBox2.Text+"',program='"+comboBox1.Text+"' where id='"+int.Parse(textBox1.Text)+"'");
           dataGridView1.DataSource= u.Displayinfo("select * from information");
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baselayer d = new Baselayer();
            d.Modificationinfo("delete from information where id='" + int.Parse(textBox1.Text) + "'");
           dataGridView1.DataSource= d.Displayinfo("select * from information");
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Baselayer s = new Baselayer();
            dataGridView1.DataSource = s.Displayinfo("select * from information where id='" + textBox3.Text + "'");

        }
    }
}
