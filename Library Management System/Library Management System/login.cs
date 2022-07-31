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

namespace Library_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FBEV0FR;Initial Catalog=Library_Management_System;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from loginTable where username='"+textBox1.Text+"'and pass='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
              
                this.Hide();
                dashboard db = new dashboard();
                 db.Show();
                 
            }
            else
            {
                MessageBox.Show("Invalid Username and Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "USERNAME") { textBox1.Clear(); }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox2.Text=="PASSWORD")
            {
                textBox2.Clear();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar='*';
        }
    }
}
