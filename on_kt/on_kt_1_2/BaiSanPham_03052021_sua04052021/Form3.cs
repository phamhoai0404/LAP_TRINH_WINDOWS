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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         
        Data dulieu = new Data();
        List<SanPham> li ;
        private void Form3_Load( object sender, EventArgs e)
        {
            li = dulieu.GetDuLieu();
            dataGridView1.DataSource = li;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham s = (SanPham)dataGridView1.CurrentRow.DataBoundItem;
            txtID.Text = s.id;
            txtTenSP.Text = s.tensp;
            txtDonGia.Text = s.dongia + "";
            txtSoLuong.Text = s.soluong + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtDonGia.Text !="" && txtID.Text!="" && txtSoLuong.Text!="" && txtTenSP.Text != "")
            {
                SanPham s = new SanPham();
                s.id = txtID.Text;
                int index = li.IndexOf(s);
                if (index == -1)
                {
                    MessageBox.Show("Không có mã sản phẩm này mà cập nhật!!", "Lỗi");
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
                            li[index] = s;
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = li;
                            dulieu.GhiDuLieu(li);
                            MessageBox.Show("Sửa thành công !", "Thông báo ");
                            this.xoaTextBox();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không sửa được sản phẩm vì giá bán và số lượng phải là số !", "Lỗi");

                    }
                }
            }
            else
            {
                MessageBox.Show("Không được để trống !!!");
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
