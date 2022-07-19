using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class Linhtinh2
    {
        SqlConnection con;
        public Linhtinh2()
        {
            string kn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=sinhviendb;Integrated Security=True";
            con = new SqlConnection(kn);
        }
        public DataTable danhsachSSV()
        {
            DataTable table = new DataTable();
            string sql = "select * from sinhvien";
            SqlDataAdapter adap = new SqlDataAdapter(sql,con);
            adap.Fill(table);
            con.Close();
            return table;
        }
    }
}
