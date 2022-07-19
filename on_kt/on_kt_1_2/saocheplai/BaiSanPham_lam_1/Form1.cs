using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiSanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data dulieu = new Data();
            List<SanPham> li = new List<SanPham>();
            li = dulieu.GetDuLieu();
            
            SanPham s = new SanPham();
            s.id = txtID.Text;

            int index = li.IndexOf(s);
            if (index != -1)
            {
                MessageBox.Show("Mã Sản Phẩm này đã tồn tại !", "Thông báo");
            }
            else
            {
                s.tensp = txtTenSP.Text;
                try
                {
                    s.soluong = int.Parse(txtSoLuong.Text);
                    s.dongia = Double.Parse(txtDonGia.Text);
                    s.thanhtien = s.soluong * s.dongia;
                    if (!(s.dongia > 0 && s.soluong >= 0))
                    {
                        MessageBox.Show("Đơn giá >0 và Số lượng >=0", "Lỗi");
                    }
                    else
                    {
                        //dulieu.AddDuLieu(s);-->có thể làm như này -->nhưng phải viết thêm hàm AddDuLieu ở class Data, nếu mà không dùng phương thức này thì không cần viết hàm AddDuLieu ở class Data
                        li.Add(s);
                        dulieu.GhiDuLieu(li);
                        MessageBox.Show("Thêm thành công !", "Thông báo");
                        this.xoaTextBox();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được sản phẩm vì giá bán và số lượng phải là số !", "Lỗi");
                }
            }
        }
        private void xoaTextBox()
        {
            txtDonGia.Clear();
            txtID.Clear();
            txtSoLuong.Clear();
            txtTenSP.Clear();
            ActiveControl = txtID;
        }
    }
}
