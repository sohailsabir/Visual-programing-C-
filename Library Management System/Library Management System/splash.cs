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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            progressBar1.BackColor = Color.Teal;
            label3.Text = start+"%";
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
