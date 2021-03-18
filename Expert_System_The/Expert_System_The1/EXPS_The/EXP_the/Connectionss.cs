using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpertSystem_The
{
    class Connectionss
    {
        SqlConnection con;
        public Connectionss()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-IDHOO3U\SQLEXPRESS;Initial Catalog=HCG;Integrated Security=True");
            con.Open();
        
        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        
        }
        public void thuchien(string sql)
        {
            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
