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
    public partial class DanhSachMonHocTheoLop : Form
    {
        public DanhSachMonHocTheoLop()
        {
            InitializeComponent();
        }

        DataUtil data = new DataUtil();
        private void DanhSachMonHocTheoLop_Load(object sender, EventArgs e)
        {
            this.hienthiDSLop();
            this.thongTinLop_Null();
        }
        private void hienthiDSLop()
        {
            comLop.DataSource = data.danhsachLopHoc();
            comLop.DisplayMember = "maLop";
            comLop.ValueMember = "maLop";
            comLop.SelectedIndex = -1;//Dùng để không hiển thị gì đầu tiên
        }
        private void thongTinLop_Null()
        {
            lblMalop.Text = "";
            lblSiso.Text = "";
            lblKhoahoc.Text = "";
            lblKhoa.Text = "";
            lblHedaotao.Text = "";
        }

        private void comLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string k = comLop.SelectedValue + "";
            DataTable bang = data.thongtinMotLop(k);
            foreach (DataRow item in bang.Rows)
            {
                lblMalop.Text = item[0].ToString();
                lblSiso.Text = item[1].ToString();
                lblKhoahoc.Text = item[2].ToString();
                lblHedaotao.Text = item[3].ToString();
                lblKhoa.Text = item[4].ToString();
            }
            //sau khi thay đổi combox thì datagridview cũng thay đổi 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.danhsachMonHocTheoLop(k);
            this.header_MonHoc();
        }
        private void header_MonHoc()
        {
            dataGridView1.Columns[0].HeaderText = "Mã môn học";
            dataGridView1.Columns[1].HeaderText = "Tên môn học";
            dataGridView1.Columns[2].HeaderText = "Số tín chỉ";
            dataGridView1.Columns[3].HeaderText = "Mã học kì";

            dataGridView1.Columns[1].Width = 300;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTrichXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1] = " ==========DANH SÁCH MÔN HỌC THEO LỚP========== ";
            worksheet.Cells[3, 2] = "Mã Lớp:" + lblMalop.Text;
            worksheet.Cells[4, 2] = "Sĩ số:" + lblSiso.Text;
            worksheet.Cells[5, 2] = "Khóa học:\t" + lblKhoahoc.Text;
            worksheet.Cells[6, 2] = " Hệ đào tạo :\t" + lblHedaotao.Text;
            worksheet.Cells[7, 2] = " Khoa:\t" + lblKhoa.Text;
            worksheet.Cells[9, 1] = "STT";
            worksheet.Cells[9, 2] = "Mã môn học";
            worksheet.Cells[9, 3] = "Tên môn";
            worksheet.Cells[9, 4] = "So TC";
            worksheet.Cells[9, 5] = " Mã học kỳ";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    worksheet.Cells[i + 10, 1] = i + 1;
                    worksheet.Cells[i + 10, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            app.Visible = true;

        }
        
    }
}
