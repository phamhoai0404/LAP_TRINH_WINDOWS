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
        List<SanPham> li = new List<SanPham>();

        private void Form3_Load( object sender, EventArgs e)
        {
            this.hienThi();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                s.soluong = int.Parse(txtSoLuong.Text);
                s.dongia = Double.Parse(txtDonGia.Text);
                s.thanhtien = s.soluong * s.dongia;
                li[index] = s;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = li;
                ghifile();
            }

        }
        private void hienThi()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream("SinhVien.bin", FileMode.Open, FileAccess.Read);
            li = (List<SanPham>)f.Deserialize(str);
            str.Close();
        }
        private void ghifile()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream("SinhVien.bin", FileMode.Create, FileAccess.Write);
            f.Serialize(str, li);
            str.Close();
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            SanPham s = (SanPham)dataGridView1.CurrentRow.DataBoundItem;
            txtID.Text = s.id;
        }
    }
}
