using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CrudApplication
{
    class Baselayer
    {
        SqlConnection con = new SqlConnection();
        public Baselayer()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M.A\Desktop\CrudApplication\CrudApplication\CRUDapplication.mdf;Integrated Security=True";
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
