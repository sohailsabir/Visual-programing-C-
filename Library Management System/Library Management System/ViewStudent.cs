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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Baselayer s2 = new Baselayer();
            dataGridView1.DataSource=s2.Display("select * from Students");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            {
                Baselayer s2=new Baselayer();
                dataGridView1.DataSource = s2.Display("select * from Students where senroll like '"+textBox1.Text+"%'");
            }
            else
            {
                Baselayer s2 = new Baselayer();
                dataGridView1.DataSource = s2.Display("select * from Students");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel2.Visible = false;
          
        }
        int sid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                sid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            Baselayer s2= new Baselayer();
            DataTable dt = s2.Display("select * from Students where stuid='" + sid + "'");
            rowid = Int64.Parse(dt.Rows[0][0].ToString());

            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();
            textBox6.Text = dt.Rows[0][5].ToString();
            textBox7.Text = dt.Rows[0][6].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated Comfirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (check == true && checkmail == true && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
                {
                    Baselayer s2 = new Baselayer();
                    s2.modification("update Students set sname='" + textBox2.Text + "',senroll='" + textBox3.Text + "',depart='" + textBox4.Text + "',semester='" + textBox5.Text + "',contact='" + textBox6.Text + "',email='" + textBox7.Text + "' where stuid=" + rowid + "");
                    dataGridView1.DataSource = s2.Display("select * from Students");
                }
                else
                {
                    MessageBox.Show("Please provide Correct Information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        bool check = false;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 10)
            {
                label10.Text = "";
                check = true;
            }
            else
            {
                label10.Text = "Invalid phone number. eg 3087893347";
                check = false;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        bool checkmail = false;
        private void textBox7_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBox7.Text, pattern))
            {
                errorProvider1.Clear();
                checkmail = true;

            }
            else
            {
                errorProvider1.SetError(this.textBox7, "please provide valid mail address");
                bool checkmail = false;

                return;
            }
        }
    }
}
