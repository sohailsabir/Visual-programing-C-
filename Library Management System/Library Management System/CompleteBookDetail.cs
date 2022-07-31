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
    public partial class CompleteBookDetail : Form
    {
        public CompleteBookDetail()
        {
            InitializeComponent();
        }

        private void CompleteBookDetail_Load(object sender, EventArgs e)
        {
            Baselayer s4 = new Baselayer();
            dataGridView1.DataSource = s4.Display("select IRBook.id as ID,Students.senroll as Enrollment,Students.sname as Student_Name,Students.depart as Department,Students.semester as Semester,Students.email as Email,Students.contact as Contact,Books.bname as Book_Name,IRBook.issuedate,IRBook.returndate from ((IRBook INNER JOIN Students ON IRBook.stuid=Students.stuid)INNER JOIN Books ON IRBook.bid=Books.bid) where  returndate is null");
            dataGridView2.DataSource = s4.Display("select IRBook.id as ID,Students.senroll as Enrollment,Students.sname as Student_Name,Students.depart as Department,Students.semester as Semester,Students.email as Email,Students.contact as Contact,Books.bname as Book_Name,IRBook.issuedate,IRBook.returndate from ((IRBook INNER JOIN Students ON IRBook.stuid=Students.stuid)INNER JOIN Books ON IRBook.bid=Books.bid) where  returndate is not null;");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
