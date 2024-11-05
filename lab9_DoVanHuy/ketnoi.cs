using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_DoVanHuy
{
    internal class ketnoi
    {
        public static SqlConnection createconnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=qlthuvien;Integrated Security=True");
            try
            {
                conn.Open();
            }catch {
                MessageBox.Show("error connection", "Thong bao"); 
            }
            return conn;
        }
        public static void thucthi(string sql)
        {
            SqlConnection con=ketnoi.createconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable truyvan(string sql)
        {
            SqlConnection con = ketnoi.createconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

    }
}
