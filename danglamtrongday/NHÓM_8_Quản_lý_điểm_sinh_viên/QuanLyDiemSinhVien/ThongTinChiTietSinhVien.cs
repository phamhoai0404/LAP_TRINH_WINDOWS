using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
//using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyDiemSinhVien
{
    public partial class ThongTinChiTietSinhVien : Form
    {
        public ThongTinChiTietSinhVien()
        {
            InitializeComponent();
        }
        public string masv;
        DataUtil data = new DataUtil();
        private void ThongTinChiTietSinhVien_Load(object sender, EventArgs e)
        {
            
            this.vietTrongThongTinCaNhan();
            this.vietTrongThongTinChung();
            this.vietcacMonDiemSinhvien();
            this.vietTongSoTinchiSinhVien();
            this.vietDiemTichLuySinhVien();
            
        }
        public void vietTrongThongTinCaNhan()
        {
            DataTable bcn = data.thongtinCanhanMotSinhvien(masv);
            lblMa.Text = bcn.Rows[0][0].ToString();
            lblTen.Text = bcn.Rows[0][1].ToString();
            lblNgaysinh.Text = bcn.Rows[0][2].ToString();
            lblGioitinh.Text = bcn.Rows[0][3].ToString();
            lblEmail.Text = bcn.Rows[0][4].ToString();
            lblQuequan.Text = bcn.Rows[0][5].ToString();
        }
        private void header_Mon_SinhVien()
        {
            dataGridView1.Columns[0].HeaderText = "Mã môn học";
            dataGridView1.Columns[1].HeaderText = "Tên môn học";
            dataGridView1.Columns[2].HeaderText = "Số tín chỉ";
            dataGridView1.Columns[3].HeaderText = "Điểm";

            dataGridView1.Columns[1].Width = 200;//Chỉnh độ rộng của cột thứ 2 có chỉ số là 1 
        }
        public void vietTrongThongTinChung()
        {
            DataTable bcn = data.thongtinChungSinhvien(masv);
            lblKhoahoc.Text = bcn.Rows[0][0].ToString();
            lblKhoaquanly.Text = bcn.Rows[0][1].ToString();
            lblLop.Text = bcn.Rows[0][2].ToString();
        }
        public void vietcacMonDiemSinhvien()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.cacMonDiemSinhvien(masv);
            this.header_Mon_SinhVien();
        }
        public void vietTongSoTinchiSinhVien()
        {
            DataTable bcn = data.thongtinTongSoTinChiSV(masv);
            lblTongSoTC.Text = bcn.Rows[0][0].ToString();
        }
        public void vietDiemTichLuySinhVien()
        {
            DataTable bcn = data.thongtinDiemTichLuySV(masv);
            lblDiemTichLuy.Text = bcn.Rows[0][0].ToString();
            double diem = Convert.ToDouble(lblDiemTichLuy.Text);
            string xl = "";
            if (diem >= 9.0) xl = "Xuất sắc";
            else if (diem >= 8.0) xl = "Giỏi";
            else if (diem >= 6.0) xl = "Khá";
            else if (diem >= 4.0) xl = "Trung Bình";
            else xl = "Yếu";
            lblXepLoai.Text = xl;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTrichxuat_Excel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1] = " BẢNG TỔNG HỢP ĐIỂM CHI TIÊT SINH VIÊN ";
            worksheet.Cells[3, 2] = "Mã SV :\t" + lblMa.Text;
            worksheet.Cells[4, 2] = " Tên SV :\t" + lblTen.Text;
            worksheet.Cells[5, 2] = " Giới tính :\t" + lblGioitinh.Text;
            worksheet.Cells[6, 2] = " Ngày sinh :\t" + lblNgaysinh.Text;
            worksheet.Cells[7, 2] = " Email :\t" + lblEmail.Text;
            worksheet.Cells[8, 2] = " Quê quán :\t" + lblQuequan.Text;
            worksheet.Cells[9, 2] = " Tổng số tín chỉ :\t" + lblTongSoTC.Text;
            worksheet.Cells[10, 2] = " Xếp loại :\t" + lblXepLoai.Text;
            worksheet.Cells[12, 1] = "STT";
            worksheet.Cells[12, 2] = "Mã môn";
            worksheet.Cells[12, 3] = "Tên môn";
            worksheet.Cells[12, 4] = "So TC";
            worksheet.Cells[12, 5] = "Điểm ";
            //Excel.export_Excel(app, dataGridView1, 18 + 2);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    worksheet.Cells[i + 13, 1] = i + 1;
                    worksheet.Cells[i + 13, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            app.Visible = true;

        }
    }
}
