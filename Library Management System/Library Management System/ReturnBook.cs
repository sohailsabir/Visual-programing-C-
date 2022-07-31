using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baselayer b1 = new Baselayer();
            DataTable dt = b1.Display("select IRBook.id,Students.senroll as Enrollment,Students.sname as Student_Name,Students.depart as Department,Students.semester,Students.email,Books.bname,IRBook.issuedate,IRBook.returndate from ((IRBook INNER JOIN Students ON IRBook.stuid=Students.stuid)INNER JOIN Books ON IRBook.bid=Books.bid) where Students.senroll='"+textBox1.Text+"' and returndate is null");
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
                textBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("INVALID ENROLMENT OR No Book Issued ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        int rowid;
        string bname;
        string idate;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                idate = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            textBox2.Text = bname;
            textBox3.Text = idate;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Baselayer s2 =new Baselayer();
            s2.modification("update IRBook set returndate='"+textBox3.Text+"' where id='"+rowid+"'");
            MessageBox.Show("Return Book Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = s2.Display("select IRBook.id,Students.senroll as Enrollment,Students.sname as Student_Name,Students.depart as Department,Students.semester,Students.email,Books.bname,IRBook.issuedate,IRBook.returndate from ((IRBook INNER JOIN Students ON IRBook.stuid=Students.stuid)INNER JOIN Books ON IRBook.bid=Books.bid) where Students.senroll='" + textBox1.Text + "' and returndate is null");
            ReturnBook_Load(this,null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Today < dateTimePicker1.Value)
            {
                MessageBox.Show("Your Selected Date is Invalid.!!!", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
