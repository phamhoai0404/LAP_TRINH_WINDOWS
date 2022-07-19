using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace bai_2
{
    class DataUtil
    {
        SqlConnection con;
        public DataUtil()
        {
            string strconnect = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=sinhviendb;Integrated Security=True";
            con = new SqlConnection(strconnect);
        }
        
        public DataTable danhsachSV()
        {
            DataTable table = new DataTable();
            string sql = "select * from sinhvien";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        
        public DataTable danhsachLophoc()
        {
            DataTable table = new DataTable();
            string sql = "select * from lophoc";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        
        public void themSV(SinhVien s)
        {
            try
            {
                con.Open();
                string sql = "INSERT into [sinhvien] values(@hoten, @dienthoai, @diachi, @malop)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("hoten", s.hoten);
                cmd.Parameters.AddWithValue("dienthoai", s.dienthoai);
                cmd.Parameters.AddWithValue("diachi", s.diachi);
                cmd.Parameters.AddWithValue("malop", s.malop);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi thêm sinh viên " + e.Message);
            }
            
        }
        public void capnhapSinhVien(SinhVien s)
        {
            try
            {
                con.Open();
                string sql = "update sinhvien set hoten=@hotennnn, dienthoai=@dienthoai, diachi=@diachi, malop=@malop where masv=@masv";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("hotennnn", s.hoten);//cái "hoten" là phải giống với @hoten vdnhư viết đây; còn hoten=@hotennn; thì hoten đó là tên thuộc tính của bảng sinhvien
                cmd.Parameters.AddWithValue("dienthoai", s.dienthoai);
                cmd.Parameters.AddWithValue("diachi", s.diachi);
                cmd.Parameters.AddWithValue("malop", s.malop);
                cmd.Parameters.AddWithValue("masv", s.masv);


                cmd.ExecuteNonQuery();
                con.Close();
               

            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi cập nhật sinh viên " + e.Message);
            }
        }
        public void xoaSinhVien(SinhVien s)
        {
            con.Open();
            string sql = "delete from sinhvien where masv= @vvvvmas";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("vvvvmas", s.masv);

            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
