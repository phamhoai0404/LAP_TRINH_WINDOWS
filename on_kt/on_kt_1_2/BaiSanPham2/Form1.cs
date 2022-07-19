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

namespace BaiSanPham2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        List<SanPham> li = new List<SanPham>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham s = new SanPham();
            s.id = txtID.Text;
            s.tensp = txtTenSP.Text;
            s.soluong = int.Parse(txtSoLuong.Text);
            s.dongia = Double.Parse(txtDonGia.Text);
            s.thanhtien = s.soluong * s.dongia;
            li.Add(s);
            this.btnGhiFile_Click();
        }
        private void btnGhiFile_Click()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream("SinhVien.bin", FileMode.Open, FileAccess.ReadWrite);
            f.Serialize(str, li);
            str.Close();
        }
    }
}
