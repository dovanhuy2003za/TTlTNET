using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class BangCap
    {
        DataBase db;

        public BangCap()
        {
            db = new DataBase();
        }
        public DataTable laydsbc()
        {
            string sql = "Select * from bangcap";
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
