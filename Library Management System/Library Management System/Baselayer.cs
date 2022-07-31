using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System
{
   public class Baselayer
    {
        SqlConnection con = new SqlConnection();
        public Baselayer()
        {
            con.ConnectionString = @"Data Source=DESKTOP-FBEV0FR;Initial Catalog=Library_Management_System;Integrated Security=True";
        }
        public void modification(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Display(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;


        }
    }
}
