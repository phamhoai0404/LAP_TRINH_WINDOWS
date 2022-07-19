using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    class DataUtil
    {
        SqlConnection con;
        public DataUtil()
        {
            string strconnect = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYDIEM;Integrated Security=True";
            con = new SqlConnection(strconnect);
        }

        public Boolean taiKhoanDangNhap(String tenTaiKhoan, String matKhau)
        {
            try
            {
                con.Open();
                string sql = "select * from DangNhap where hotenDangNhap = @hoten and matKhauDangNhap = @matkhau";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("hoten", tenTaiKhoan);
                cmd.Parameters.AddWithValue("matkhau", matKhau);

                SqlDataReader doc = cmd.ExecuteReader();
                Boolean daura = doc.Read();//xem nó có dòng nào hay không nếu có thì true, còn không thì là false
                con.Close();
                return daura;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu" + e.Message);
                return false;
            }

        }
        public DataTable danhsachKhoa()
        {
            DataTable table = new DataTable();
            string sql = "select * from KhoaDaoTao";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhsachHocKy()
        {
            DataTable table = new DataTable();
            string sql = "select * from HocKy";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhsachMonHoc()
        {
            DataTable table = new DataTable();
            string sql = " select  * from MonHoc";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable danhsachLopHoc()
        {
            DataTable table = new DataTable();
            string sql = " select  * from Lop";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable danhsachSinhVien()
        {
            DataTable table = new DataTable();
            string sql = @"select * from danhsachSV";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable danhsachGiangVien()
        {
            DataTable table = new DataTable();
            string sql = " select * from GiangVien";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable danhsachDiemToanBo()
        {
            DataTable table = new DataTable();
            string sql = "select maMonHoc, SinhVien.maSV, hoTenSV, diem from DiemThi inner join SinhVien on DiemThi.maSV = SinhVien.maSV";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable danhsachSinhVienTheoLop(String malop)
        {
            DataTable table = new DataTable();
            String sql = "";
            if (malop != "")
            {
                sql = @"select SinhVien.maSV, hoTenSV,gioiTinh, queQuan, round(sum(diem*soTinChi)/sum(soTinChi),1) as 'TB'
                         from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
                                      inner join Lop on Lop.maLop = SinhVien.maLop
                                      inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
                         where Lop.maLop = '" + malop + @"'
                         group by SinhVien.maSV, hoTenSV,gioiTinh, queQuan";//cho @sau dấu + mục đích là vì nó có kiểu kí tự đặc biệt  
            }
            else
            {
                sql = @"select SinhVien.maSV, hoTenSV,gioiTinh, queQuan, round(sum(diem*soTinChi)/sum(soTinChi),1) as 'TB'
                        from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
                                      inner join Lop on Lop.maLop = SinhVien.maLop
                                      inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
                        group by SinhVien.maSV, hoTenSV,gioiTinh, queQuan";//cho @sau dấu + mục đích là vì nó có kiểu kí tự đặc biệt 
            }
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;

        }
        public DataTable danhsachSinhVien_nhapDiemLopMon(string malop)
        {
            DataTable table = new DataTable();
            string sql = @"select maSV, hoTenSV  
                           from SinhVien inner join Lop on Lop.maLop = SinhVien.maLop
                           where Lop.maLop = '" + malop + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhsachMonHocTheoLop(String malop)
        {
            DataTable table = new DataTable();
            String sql = "";
            if (malop != "")
            {
                sql = @"select  MonHoc.maMonHoc,tenMonHoc, soTinChi, maHocKy
                         from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
                                      inner join Lop on Lop.maLop = SinhVien.maLop
                                      inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
                         where Lop.maLop = '" + malop + @"'
                         group by MonHoc.maMonHoc,tenMonHoc, soTinChi, maHocKy";//cho @sau dấu + mục đích là vì nó có kiểu kí tự đặc biệt  
            }
            else
            {
                sql = @"select * from MonHoc";
            }
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;

        }

        public DataTable thongtinCanhanMotSinhvien(String masv)
        {
            DataTable table = new DataTable();
            string sql = "select * from thongtinCanhanMotSinhvien('" + masv + "')";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable thongtinChungSinhvien(String masv)
        {
            DataTable table = new DataTable();
            string sql = "select * from thongtinChungSinhvien('" + masv + "')";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable thongtinTongSoTinChiSV(String masv)
        {
            DataTable table = new DataTable();
            string sql = "select * from tongSoTinchiSinhVien('" + masv + "')";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable thongtinDiemTichLuySV(String masv)
        {
            DataTable table = new DataTable();
            string sql = "select * from diemTichluySV('" + masv + "')";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable thongtinMotLop(string malop)
        {
            DataTable table = new DataTable();
            string sql = @"select maLop, siSo,khoaHoc, heDaoTao,tenKhoa
		                   from Lop inner join KhoaDaoTao on Lop.maKhoa = KhoaDaoTao.maKhoa
		                   where maLop='" + malop + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable cacMonDiemSinhvien(String masv)
        {
            DataTable table = new DataTable();
            string sql = "select * from cacMonDiemSinhvien('" + masv + "')";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable thongTinCaNhanGiangVien(String magv)
        {
            DataTable table = new DataTable();
            string sql = @"select * from GiangVien
                           where maGV = '" + magv + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable cacMonDayCuaGiangVien(String magv)
        {
            DataTable table = new DataTable();
            string sql = @"select MonHoc.maMonHoc, tenMonHoc, soTinChi,phongHocTheoMon,thoiGianBatDauMonHoc,maHocKy
                        from GiangVien_MonHoc inner join MonHoc on GiangVien_MonHoc.maMonHoc = MonHoc.maMonHoc
                        where maGV = '" + magv + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);

            adap.Fill(table);
            con.Close();
            return table;
        }

        public void xoaKhoa(String maKhoa, String tenKhoa)
        {

            //Thực hiện kiểm tra xem nó có tồn tại hay không
            Boolean dong = this.kiemtraTonTaiMaKhoa(maKhoa);

            if (dong)//Nếu mà tồn tại thì 
            {
                DialogResult d = MessageBox.Show("Bạn đã chắc chắn xóa Khoa  " + tenKhoa, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d.Equals(DialogResult.Yes))
                {
                    try
                    {
                        con.Open();
                        string sql = "delete from KhoaDaoTao where maKhoa=@ma ";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ma", maKhoa);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không xóa được vì rằng buộc khóa ngoài với bảng Lớp ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

                }
            }
            else//Nếu cái khoa ấy Không tồn tại
            {
                MessageBox.Show("Không xóa được vì không có mã khoa này  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void xoaMonHoc(MonHoc s)
        {

            //Thực hiện kiểm tra xem nó có tồn tại hay không
            Boolean dong = this.kiemtraTonTaiMaMonHoc(s.maMH);

            if (dong)//Nếu mà tồn tại thì 
            {
                DialogResult d = MessageBox.Show("Bạn đã chắc chắn xóa mã môn hoc: " + s.maMH, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d.Equals(DialogResult.Yes))
                {
                    try
                    {
                        con.Open();
                        string sql = "delete from MonHoc where maMonHoc = @ma";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ma", s.maMH);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không xóa được vì rằng buộc khóa ngoài ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
            }
            else//Nếu Không tồn tại
            {
                MessageBox.Show("Không tồn tại mã môn học này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaLop(Lop s)
        {
            //Thực hiện kiểm tra xem mã lớp nó có tồn tại hay không
            Boolean dong = this.kiemtraTonTaiMaLop(s.malop);

            if (dong)//Nếu mà tồn tại thì 
            {
                DialogResult d = MessageBox.Show("Bạn đã chắc chắn xóa mã lớp hoc: " + s.malop, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d.Equals(DialogResult.Yes))
                {
                    try
                    {
                        con.Open();
                        string sql = "delete from Lop where maLop = @ma";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ma", s.malop);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không xóa được vì rằng buộc khóa ngoài với bảng Sinh Viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
            }
            else//Nếu Không tồn tại
            {
                MessageBox.Show("Không tồn tại mã lớp để xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaDiemTrongBang(String maMH, String maSV)
        {

            //Thực hiện kiểm tra xem nó có tồn tại hay không
            Boolean dong = this.kiemtraTonTaiMotDiemCuaSV(maMH, maSV);

            if (dong)//Nếu mà tồn tại thì 
            {
                DialogResult d = MessageBox.Show("Bạn đã chắc chắn xóa mã môn hoc: " + maMH + " của mã sinh viên: " + maSV, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d.Equals(DialogResult.Yes))
                {
                    con.Open();
                    string sql = "delete from DiemThi where maMonHoc =@mamon and maSV=@masv";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("mamon", maMH);
                    cmd.Parameters.AddWithValue("masv", maSV);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else//Nếu Không tồn tại
            {
                MessageBox.Show("Không xóa được vì bạn nhập sai !");
            }
        }
        public void suaKhoa(String maKhoa, String tenKhoa, String sodienthoai)
        {
            try
            {
                //Thực hiện kiểm tra xem nó có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMaKhoa(maKhoa);

                if (dong)//Nếu mà tồn tại thì 
                {

                    DialogResult d = MessageBox.Show("Bạn đã chắc chắn sửa  hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d.Equals(DialogResult.Yes))
                    {
                        con.Open();
                        string sql = "update KhoaDaoTao set  tenKhoa =@ten , dienThoaiLienHe = @sdt where maKhoa=@ma";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ma", maKhoa);
                        cmd.Parameters.AddWithValue("ten", tenKhoa);
                        cmd.Parameters.AddWithValue("sdt", sodienthoai);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Khoa này không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi sửa khoa " + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void suaMonHoc(MonHoc s)
        {
            try
            {
                //Thực hiện kiểm tra xem nó có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMaMonHoc(s.maMH);

                if (dong)//Nếu mà tồn tại thì 
                {

                    DialogResult d = MessageBox.Show("Bạn đã chắc chắn sửa  hay không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d.Equals(DialogResult.Yes))
                    {
                        con.Open();
                        string sql = "update MonHoc set  tenMonHoc = @ten, soTinChi= @sotc, maHocKy =@maHK where maMonHoc=@ma";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ma", s.maMH);
                        cmd.Parameters.AddWithValue("ten", s.tenMH);
                        cmd.Parameters.AddWithValue("sotc", s.sotc);
                        cmd.Parameters.AddWithValue("maHK", s.maHocKy);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Môn học này không tồn tại để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi sửa mã môn học " + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void suaLop(Lop s)
        {
            try
            {
                //Thực hiện kiểm tra xem lớp nó có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMaLop(s.malop);

                if (dong)//Nếu mà tồn tại thì 
                {

                    DialogResult d = MessageBox.Show("Bạn đã chắc chắn sửa  hay không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d.Equals(DialogResult.Yes))
                    {
                        con.Open();
                        string sql = "update Lop set  tenLop = @ten, heDaoTao = @he, khoaHoc =@khoahoc, siSo = @siso, maKhoa = @makhoa where maLop = @malop";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("ten", s.tenlop);
                        cmd.Parameters.AddWithValue("he", s.hedaotao);
                        cmd.Parameters.AddWithValue("khoahoc", s.khoahoc);
                        cmd.Parameters.AddWithValue("siso", s.siso);
                        cmd.Parameters.AddWithValue("makhoa", s.makhoa);
                        cmd.Parameters.AddWithValue("malop", s.malop);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                { 
                    MessageBox.Show("Mã Môn học này không tồn tại để sửa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi sửa mã môn học " + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void suaDiemMHSV(String mamon, String masv, float diem)
        {
            try
            {
                //Thực hiện kiểm tra xem nó có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMotDiemCuaSV(mamon, masv);

                if (dong)//Nếu mà tồn tại thì 
                {
                    DialogResult d = MessageBox.Show("Bạn đã chắc chắn sửa  hay không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d.Equals(DialogResult.Yes))
                    {
                        con.Open();
                        string sql = "update DiemThi set  diem = @diem where maMonHoc =@mamon and maSV =@masv";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("diem", diem);
                        cmd.Parameters.AddWithValue("mamon", mamon);
                        cmd.Parameters.AddWithValue("masv", masv);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã điểm : " + mamon + " của bạn sinh viên có mã: " + masv + "!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi sửa mã môn học " + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void suaDiemMHSV_2(String mamon, String masv, float diem)
        {
            try
            {
                con.Open();
                string sql = "update DiemThi set  diem = @diem where maMonHoc =@mamon and maSV =@masv";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("diem", diem);
                cmd.Parameters.AddWithValue("mamon", mamon);
                cmd.Parameters.AddWithValue("masv", masv);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi khi sửa mã môn học " + e.Message);
            }
        }
        public Boolean kiemtraTonTaiMaKhoa(String maKhoa)
        {
            con.Open();
            string sql = "select * from KhoaDaoTao where maKhoa=@ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma", maKhoa);

            SqlDataReader doc = cmd.ExecuteReader();
            Boolean dong = doc.Read();
            con.Close();
            return dong;
        }

        public Boolean kiemtraTonTaiMotDiemCuaSV(String maMon, String maSV)
        {
            con.Open();
            string sql = "select * from DiemThi where maMonHoc=@maM and maSV =@maSV ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("maM", maMon);
            cmd.Parameters.AddWithValue("maSV", maSV);

            SqlDataReader doc = cmd.ExecuteReader();
            Boolean dong = doc.Read();
            con.Close();
            return dong;
        }
        public Boolean kiemtraTonTaiMaMonHoc(String maMH)
        {
            con.Open();
            string sql = "select * from MonHoc where maMonHoc = @ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma", maMH);

            SqlDataReader doc = cmd.ExecuteReader();
            Boolean dong = doc.Read();
            con.Close();
            return dong;
        }
        public Boolean kiemtraTonTaiMaLop(String maLop)
        {
            con.Open();
            string sql = "select * from Lop where maLop =@ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma", maLop);

            SqlDataReader doc = cmd.ExecuteReader();
            Boolean dong = doc.Read();
            con.Close();
            return dong;
        }
        public Boolean kiemtraTonTaiMaSinhVien(String masv)
        {
            con.Open();
            string sql = "select * from SinhVien where maSV = @masv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("masv", masv);

            SqlDataReader doc = cmd.ExecuteReader();
            Boolean dong = doc.Read();
            con.Close();
            return dong;
        }
        public void themKhoa(String maKhoa, String tenKhoa, String sodienthoai)
        {
            try
            {
                //Thực hiện kiểm tra xem nó có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMaKhoa(maKhoa);

                if (!dong)//Nếu mà không tồn tại
                {
                    con.Open();
                    string sql = "insert into KhoaDaoTao values (@makhoa, @tenkhoa, @sdt)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("makhoa", maKhoa);
                    cmd.Parameters.AddWithValue("tenkhoa", tenKhoa);
                    cmd.Parameters.AddWithValue("sdt", sodienthoai);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại mã khoa này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi thêm Khoa này: " + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void themMonHoc(MonHoc s)
        {
            try
            {
                //Thực hiện kiểm tra xem nó có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMaMonHoc(s.maMH);

                if (!dong)//Nếu mà không tồn tại
                {
                    con.Open();
                    string sql = "insert into MonHoc values (@ma, @ten,@stc, @mahk)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("ma", s.maMH);
                    cmd.Parameters.AddWithValue("ten", s.tenMH);
                    cmd.Parameters.AddWithValue("stc", s.sotc);
                    cmd.Parameters.AddWithValue("mahk", s.maHocKy);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại  môn học này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi khi thêm môn học này " + e.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void themLop(Lop s)
        {
            try
            {
                //Thực hiện kiểm tra xem mã lớp có tồn tại hay không
                Boolean dong = this.kiemtraTonTaiMaLop(s.malop);

                if (!dong)//Nếu mà không tồn tại
                {
                    con.Open();
                    string sql = "insert into Lop values (@ma, @ten,@he, @khoahoc,@siso, @makhoa)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("ma", s.malop);
                    cmd.Parameters.AddWithValue("ten", s.tenlop);
                    cmd.Parameters.AddWithValue("he", s.hedaotao);
                    cmd.Parameters.AddWithValue("khoahoc", s.khoahoc);
                    cmd.Parameters.AddWithValue("siso", s.siso);
                    cmd.Parameters.AddWithValue("makhoa", s.makhoa);


                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại mã lớp  này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi khi thêm lớp này " + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void themDiemMonHoc_2(String maMon, String maSV, float diem)
        {
            con.Open();
            string sql = "insert into DiemThi values(@mamon, @masv, @diem)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mamon", maMon);
            cmd.Parameters.AddWithValue("masv", maSV);
            cmd.Parameters.AddWithValue("diem", diem);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable timKiemSinhVien(String khoa, String malophoc, String masv)
        {

            string sql;
            if (!masv.Trim().Equals(""))
            {
                sql = "select* from timtheomasinhvien('" + masv + "')";
            }
            else
            {
                if (!malophoc.Trim().Equals(""))
                {
                    sql = "select* from timtheomalop('" + malophoc + "')";
                }
                else
                {
                    if (!khoa.Trim().Equals(""))
                    {
                        sql = "select* from timtheotenkhoa(N'" + khoa + "')";
                    }
                    else
                    {
                        sql = "select * from danhsachSV";
                    }

                }

            }

            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable timKiemGiangVienTheoMon(string k)
        {
            string sql = @"select GiangVien.maGV, hoTenGV, ngaySinh, gioiTinh, email, queQuan, namBatDauCongTac
                           from GiangVien inner join GiangVien_MonHoc on GiangVien.maGV = GiangVien_MonHoc.maGV
                           where maMonHoc = '" + k + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable timKiem_Lop_TheoMaKhoa(string tenkhoa)
        {
            string sql = @"select *
                           from KhoaDaoTao inner join lop on lop.maKhoa = KhoaDaoTao.maKhoa
                           where lop.maKhoa = '" + tenkhoa + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable timKiem_MaSinhVien_TheoMaLop(string malop)
        {
            string sql = @"select * 
                           from lop inner join SinhVien on SinhVien.maLop = lop.maLop
                           where SinhVien.maLop = '" + malop + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable timKiem_MaSinhVien_TheoMaKhoa(string makhoa)
        {
            string sql = @"select * 
                           from lop inner join SinhVien on SinhVien.MaLop = lop.MaLop
		                   inner join KhoaDaoTao on KhoaDaoTao.MaKhoa = lop.maKhoa
                           where KhoaDaoTao.maKhoa = '" + makhoa + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            con.Close();
            return table;
        }
        public void thuchienThemDiem(DataGridView dgv)
        {
            int hang = dgv.Rows.Count;
            for (int i = 0; i < hang; i++)
            {
                string mamon = dgv.Rows[i].Cells[0].Value.ToString();
                string masv = dgv.Rows[i].Cells[1].Value.ToString();
                float diem = float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                if (kiemtraTonTaiMotDiemCuaSV(mamon, masv))
                {
                    this.suaDiemMHSV_2(mamon, masv, diem);
                }
                else
                {
                    this.themDiemMonHoc_2(mamon, masv, diem);
                }
            }

        }
        public DataTable diemMaMon_MaSV(string mamon, string masv)
        {
            DataTable table = new DataTable();
            string sql = "select diem from DiemThi where maMonHoc='" + mamon + "' and maSV ='" + masv + "' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }


    }
}
