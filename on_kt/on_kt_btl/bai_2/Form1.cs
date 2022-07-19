using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataUtil data = new DataUtil();
        Linhtinh2 linhtinh = new Linhtinh2();
        List<SinhVien> li = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.hienthidanhsach();
            this.hienthidsLophoc();
            txtMasv.Enabled = false;
            ActiveControl = txtHoten;
        }
        private void hienthidanhsach()
        {
            try
            {
                //li = data.danhsachSV();
              //  dataGridView1.DataSource = linhtinh.danhsachSSV();
                
              
            }
            catch (Exception e)
            {

                MessageBox.Show("Có lỗi xảy ra " +e.Message,"Thông báo");
            }
            
        }
        private void hienthidsLophoc()
        {
            comboBox1.DataSource = data.danhsachLophoc();
            comboBox1.DisplayMember = "tenlop";
            comboBox1.ValueMember = "malop";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien s = new SinhVien();
            s.hoten = txtHoten.Text;
            s.dienthoai = txtDienthoai.Text;
            s.diachi = txtDiachi.Text;
            // s.malop = int.Parse(txtMalop.Text);
            s.malop =Convert.ToInt16(comboBox1.SelectedValue);
            data.themSV(s);
            this.hienthidanhsach();
            xoaTexBox();
        }
        private void xoaTexBox()
        {
            txtMasv.Clear();
            txtHoten.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            comboBox1.SelectedIndex = 0;
            ActiveControl = txtHoten;
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*int hang = e.RowIndex;
                txtMasv.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                txtHoten.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtDiachi.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txtDienthoai.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                comboBox1.SelectedIndex = Convert.ToInt16(dataGridView1.Rows[hang].Cells[4].Value.ToString()) - 1;*/
                int hang = e.RowIndex;
                txtMasv.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.Rows[hang].Cells[4].Value.ToString();

            }
            catch (Exception r)
            {

                MessageBox.Show("Có lỗi xảy ra " + r.Message);
            }

            



        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien s = new SinhVien();
                s.masv = int.Parse(txtMasv.Text);
                s.hoten = txtHoten.Text;
                s.dienthoai = txtDienthoai.Text;
                s.diachi = txtDiachi.Text;
                s.malop = Convert.ToInt16(comboBox1.SelectedValue);
                data.capnhapSinhVien(s);
                this.hienthidanhsach();
                xoaTexBox();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Có lỗi khi cập nhật mã sinh viên : " + exx.Message, "Thông báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien s = new SinhVien();
                s.masv = int.Parse(txtMasv.Text);
                data.xoaSinhVien(s);
                hienthidanhsach();
                xoaTexBox();
            }
            catch (Exception exxx)
            {

                MessageBox.Show("Có lỗi khi xóa sinh viên "+exxx.Message);
            }
        }
            
    }
}
