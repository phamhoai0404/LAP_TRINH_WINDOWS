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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txtTaiKhoan;
        }
        DataUtil data = new DataUtil();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtmatkhau.Text =="" || txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(data.taiKhoanDangNhap(txtTaiKhoan.Text, txtmatkhau.Text))
                {
                    QuanLyDiemSV f2 = new QuanLyDiemSV();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
