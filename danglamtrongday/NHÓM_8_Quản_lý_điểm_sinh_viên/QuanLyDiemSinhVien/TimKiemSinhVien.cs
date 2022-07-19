using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class TimKiemSinhVien : Form
    {
        public TimKiemSinhVien()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void comKhoaQuanLy_SelectedValueChanged(object sender, EventArgs e)
        {
            string k = comKhoaQuanLy.SelectedValue + "";

            //comLop
            comLop.DataSource = data.timKiem_Lop_TheoMaKhoa(k);
            comLop.DisplayMember = "maLop";
            comLop.ValueMember = "maLop";
            comLop.SelectedIndex = -1;
            //comSinhVien
            comMaSV.DataSource = data.timKiem_MaSinhVien_TheoMaKhoa(k);
            comMaSV.DisplayMember = "maSV";
            comMaSV.ValueMember = "maSV";
            comMaSV.SelectedIndex = -1;
        }

        private void comLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string k = comLop.SelectedValue + "";
            comMaSV.DataSource = data.timKiem_MaSinhVien_TheoMaLop(k);
            comMaSV.DisplayMember = "maSV";
            comMaSV.ValueMember = "maSV";
            comMaSV.SelectedIndex = -1;
        }

        private void TimKiemSinhVien_Load(object sender, EventArgs e)
        {
            this.hienthiDSKhoa();
            this.hienthiDSLop();
            this.hienthiDSMaSV();
        }
        private void hienthiDSKhoa()
        {
            comKhoaQuanLy.DataSource = data.danhsachKhoa();
            comKhoaQuanLy.DisplayMember = "tenKhoa";
            comKhoaQuanLy.ValueMember = "maKhoa";
            comKhoaQuanLy.SelectedIndex = -1;
        }
        private void hienthiDSLop()
        {
            comLop.DataSource = data.danhsachLopHoc();
            comLop.DisplayMember = "maLop";
            comLop.ValueMember = "maLop";
            comLop.SelectedIndex = -1;
        }
        private void hienthiDSMaSV()
        {
            comMaSV.DataSource = data.danhsachSinhVien();
            comMaSV.DisplayMember = "maSV";
            comMaSV.ValueMember = "maSV";
            comMaSV.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.hienthiDSKhoa();
            this.hienthiDSLop();
            this.hienthiDSMaSV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string masv = comMaSV.Text + "";
            if ( masv != "")
            {
                if (data.kiemtraTonTaiMaSinhVien(masv))
                {
                    ThongTinChiTietSinhVien f1 = new ThongTinChiTietSinhVien();
                    f1.masv = masv;
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có mã sinh viên này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa có mã sinh viên để tìm kiếm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
