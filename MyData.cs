using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2
{
    public class MyData
    {
        public string sqlstr = ConfigurationManager.ConnectionStrings["sqlstr"].ConnectionString;
        public string cs = "";
        public DataTable ShowDate(string cs)
        {
            SqlConnection con1 = new SqlConnection(sqlstr);
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter(cs, con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con1.Close();
            return dt;


        }
        public void ManData()
        {
            SqlConnection con1 = new SqlConnection(sqlstr);
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = cs;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
            con1.Close();
        }

        public bool SearchDate(string id)
        {
            SqlConnection con1 = new SqlConnection(sqlstr);
            string cs = "SELECT * FROM sstudent where stno = @id ";
            SqlCommand c1 = new SqlCommand(cs, con1);
            c1.Parameters.AddWithValue("@id", id);
            con1.Open();
            SqlDataReader dr = c1.ExecuteReader();
            return dr.HasRows;
        }
    }
}
