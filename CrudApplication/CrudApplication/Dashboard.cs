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
    public partial class Dashboard : Form
    {
        string Gender = "";
        public Dashboard()
        {
            InitializeComponent();
            Baselayer s = new Baselayer();
            dataGridView1.DataSource = s.Display("select * from student");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Baselayer s = new Baselayer();
            dataGridView1.DataSource=s.Display("select * from Student where username='"+textBox8.Text+"'");
        }
        int id;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            Baselayer s = new Baselayer();
            DataTable dt = s.Display("select * from student where Id='"+id+"'");
            rowid = int.Parse(dt.Rows[0][0].ToString());
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][4].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            textBox5.Text = dt.Rows[0][6].ToString();
            textBox6.Text = dt.Rows[0][7].ToString();
            textBox7.Text = dt.Rows[0][8].ToString();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!=""&&Gender!=""&&textBox3.Text!=""&&textBox4.Text!=""&&textBox5.Text!=""&&textBox6.Text!=""&&textBox7.Text!="")
            {
                Baselayer s1 = new Baselayer();
                s1.modification("update student set username='"+textBox1.Text+"',phone='"+textBox2.Text+"',gender='"+Gender+"',mmarks='"+int.Parse(textBox3.Text)+"',fscmarks='"+int.Parse(textBox4.Text)+"',ntsmarks='"+int.Parse(textBox5.Text)+"',cnic='"+textBox6.Text+"',password='"+textBox7.Text+"' where Id='"+rowid+"'");
                MessageBox.Show("Data Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Baselayer s = new Baselayer();
                dataGridView1.DataSource = s.Display("select * from Student");
            }
            else
            {
                MessageBox.Show("Empty Feild Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "FeMale";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && Gender != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                Baselayer s1 = new Baselayer();
                s1.modification("delete from student where Id='"+rowid+"'");
                MessageBox.Show("Data Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Baselayer s = new Baselayer();
                dataGridView1.DataSource = s.Display("select * from Student");
            }
            else
            {
                MessageBox.Show("Empty Feild Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if(textBox8.Text=="")
            {
                Baselayer s = new Baselayer();
                dataGridView1.DataSource = s.Display("select * from student");
            }
        }
    }
}
