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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            Baselayer s3 = new Baselayer();
           DataTable dt =s3.Display("Select bname from Books");
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               comboBox1.Items.Add(dt.Rows[i][0].ToString());
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""){
            
            Baselayer s3 = new Baselayer();
            DataTable dt = s3.Display("select * from Students where senroll='"+textBox1.Text+"'");
            textBox1.ReadOnly=true;
            if(dt.Rows.Count !=0)
            {
                textBox2.Text = dt.Rows[0][1].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
                textBox5.Text = dt.Rows[0][5].ToString();
                textBox6.Text = dt.Rows[0][6].ToString();
            }
            else
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                MessageBox.Show("Ivalid Enrollment No","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        }
        int count;
        bool issuecheckbook = false;
        int n = 1;
        private void button4_Click(object sender, EventArgs e)
        {
            Baselayer s3 = new Baselayer();
            DataTable dt = s3.Display("select count(stuid) from IRBook where returndate is null and stuid in(select stuid from Students where senroll='"+textBox1.Text+"' );");
            count =int.Parse(dt.Rows[0][0].ToString());
            if(textBox2.Text!="")
            {
                if(comboBox1.SelectedIndex!=-1 && count<=3)
                {
                    
                    int bid;
                    int sid;
                    DataTable dt1=s3.Display("select bid from Books where bname='"+comboBox1.Text+"'");
                    bid = int .Parse(dt1.Rows[0][0].ToString());
                    DataTable dt2 = s3.Display("select stuid from Students where senroll='" + textBox1.Text + "'");
                    sid = int.Parse(dt2.Rows[0][0].ToString());
                    s3.modification("insert into IRBook(stuid,bid,issuedate) values("+sid+","+bid+",'"+dateTimePicker1.Text+"')");
                    MessageBox.Show("Book Issued","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView1.Rows.Add(n,textBox1.Text,textBox2.Text,comboBox1.Text,dateTimePicker1.Text);
                    n = n + 1;
                    issuecheckbook = true;
                    
                }
                else
                {
                    MessageBox.Show("Select Book OR Maximum numbers of Books has been ISSUED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
                
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedValue=-1;
                

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ReadOnly = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex=-1;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure", "Comfirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today < dateTimePicker1.Value)
            {
                MessageBox.Show("Your Selected Date is Invalid.!!!", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(issuecheckbook==true)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please First Issue the Book then Click the Print Button","Informatrion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ID;
            string eroll;
            string name;
            string bname;
            string date;
            int pro = 120;
            e.Graphics.DrawString("\t\tLIBRARY MANAGEMENT SYSTEM",new Font("Century Gothic",18,FontStyle.Bold),Brushes.Green,new Point(80));
            e.Graphics.DrawString("\t\t\tIssued Book To Student", new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Red, new Point(80,40));
            e.Graphics.DrawString("ID      Enrollment No\t    Name\t  Book Name\tIssued Date", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(26,80));
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                ID = Convert.ToInt32(row.Cells["Column1"].Value);
                eroll = "" + row.Cells["Column2"].Value;
                name= "" + row.Cells["Column3"].Value;
                bname = "" + row.Cells["Column4"].Value;
                date = "" + row.Cells["Column5"].Value;
                e.Graphics.DrawString("" + ID, new Font("Century Gothic",12,FontStyle.Bold),Brushes.Black,new Point(30,pro));
                e.Graphics.DrawString("    " +eroll, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(80, pro));
                e.Graphics.DrawString("\t     " + name, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(180, pro));
                e.Graphics.DrawString("\t\t" + bname, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(280, pro));
                e.Graphics.DrawString("\t\t\t" + date, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(380, pro));
                pro = pro + 20;
            }
            e.Graphics.DrawString("\t************Thank for visiting*************", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Green, new Point(80,pro));
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
    }
}
