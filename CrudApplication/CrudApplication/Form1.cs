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

namespace CrudApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M.A\Desktop\CrudApplication\CrudApplication\CRUDapplication.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from student where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                Dashboard d = new Dashboard();
                this.Hide();
                d.Show();
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s = new Student();
            s.Show();
        }
    }
}
