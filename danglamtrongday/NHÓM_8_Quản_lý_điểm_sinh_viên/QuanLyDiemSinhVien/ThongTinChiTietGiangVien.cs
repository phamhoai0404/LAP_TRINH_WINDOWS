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
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyDiemSinhVien
{
    public partial class ThongTinChiTietGiangVien : Form
    {
        public ThongTinChiTietGiangVien()
        {
            InitializeComponent();
        }
        public string maGV;
        DataUtil data = new DataUtil();
        private void ThongTinChiTietGiangVien_Load(object sender, EventArgs e)
        {
            this.thongTinCaNhan();
            this.thongtinMonDayGiangVien();
        }
        private void thongTinCaNhan()
        {
            DataTable bang = data.thongTinCaNhanGiangVien(maGV);
            lblMaGV.Text = bang.Rows[0][0].ToString();
            lblTenGV.Text = bang.Rows[0][1].ToString();
            lblNgaySinh.Text = bang.Rows[0][2].ToString();
            lblGioiTinh.Text = bang.Rows[0][3].ToString();
            lblEmail.Text = bang.Rows[0][4].ToString();
            lblQuequan.Text = bang.Rows[0][5].ToString();
            lblNamCongTac.Text = bang.Rows[0][6].ToString();
        }
        private void header_Mon_GiangVien()
        {
            dataGridView1.Columns[0].HeaderText = "Mã môn học";
            dataGridView1.Columns[1].HeaderText = "Tên môn học";
            dataGridView1.Columns[2].HeaderText = "Số tín chỉ";
            dataGridView1.Columns[3].HeaderText = "Phòng dạy";
            dataGridView1.Columns[4].HeaderText = "Thời gian bắt đầu";
            dataGridView1.Columns[5].HeaderText = "Mã học kì";

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[5].Width = 60;

        }
        private void thongtinMonDayGiangVien()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.cacMonDayCuaGiangVien(maGV);
            this.header_Mon_GiangVien();
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

            worksheet.Cells[1, 1] = " ==========BẢNG TỔNG HỢP ĐIỂM CHI TIÊT GIẢNG VIÊN========== ";
            worksheet.Cells[3, 2] = "Mã Giảng viên\t:" + lblMaGV.Text;
            worksheet.Cells[4, 2] = " Tên Giảng Viên:" + lblTenGV.Text;
            worksheet.Cells[5, 2] = " Giới tính:\t" + lblGioiTinh.Text;
            worksheet.Cells[6, 2] = " Ngày sinh:\t" + lblNgaySinh.Text;
            worksheet.Cells[7, 2] = " Email:\t" + lblEmail.Text;
            worksheet.Cells[8, 2] = " Quê quán:\t" + lblQuequan.Text;
            worksheet.Cells[9, 2] = " Năm công tác:\t" + lblNamCongTac.Text;
            worksheet.Cells[11, 1] = "STT";
            worksheet.Cells[11, 2] = "Mã môn";
            worksheet.Cells[11, 3] = "Tên môn học";
            worksheet.Cells[11, 4] = "So TC";
            worksheet.Cells[11, 5] = "Phòng dạy";
            worksheet.Cells[11, 6] = "Thời gian bắt đầu";
            worksheet.Cells[11, 7] = " Mã học kỳ";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 12, 1] = i + 1;
                    worksheet.Cells[i + 12, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            app.Visible = true;
        }
    }
}
