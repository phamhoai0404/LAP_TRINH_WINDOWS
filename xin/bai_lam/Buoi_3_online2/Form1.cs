using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3_online2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSo1;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double kq = 0;
                if (radCong.Checked)
                    kq = so1 + so2;
                else if (radTru.Checked)
                    kq = so1 - so2;
                else if (radNhan.Checked)
                    kq = so1 * so2;
                else if (radChia.Checked)
                    kq = so1 / so2;

                txtKetQua.Text = kq + "";
            }
            catch
            {
                MessageBox.Show("Có lỗi khi nhập hai số !", "Thông Báo");
            }
        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                //có hai cách 
                //txtKetQua.Text = Convert.ToString(so1 + so2);
                txtKetQua.Text = (so1 + so2) + "";
            }
            catch
            {
                MessageBox.Show("Hai số nhập vào đã có lỗi !", "Thông Báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKetQua.Text = Convert.ToString(so1 - so2);
            }
            catch
            {
                MessageBox.Show("Hai số nhập vào đã có lỗi !", "Thông Báo");
            }

        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKetQua.Text = Convert.ToString(so1 * so2);
            }
            catch
            {
                MessageBox.Show("Hai số nhập vào đã có lỗi !", "Thông Báo");
            }
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                if (so2 != 0)
                {
                    txtKetQua.Text = Convert.ToString(so1 / so2);

                }
                else
                {
                    MessageBox.Show("Số thứ hai băng 0 !", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Hai số nhập vào đã có lỗi !", "Thông Báo");
            }
        }
    }
}
