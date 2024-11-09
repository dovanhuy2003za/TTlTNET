using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class DataBase
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        public DataBase()
        {
            string strcon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLThuvien;Integrated Security=True";
            conn = new SqlConnection(strcon);
        }
        public DataTable Execute(string sql) 
        {
            adapter=new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string sql, SqlParameter[] sqlParameters=null)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (sqlParameters!=null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
