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
        List<SanPham> li = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = li;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham s = new SanPham();
            s.id = txtID.Text;
            s.tensp = txtTenSP.Text;
            s.soluong = int.Parse(txtSoLuong.Text);
            s.dongia = Double.Parse(txtDonGia.Text);
            s.thanhtien = s.soluong * s.dongia;
            li.Add(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li;
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream("SinhVien.bin", FileMode.OpenOrCreate, FileAccess.Write);
            f.Serialize(str, li);
            str.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
