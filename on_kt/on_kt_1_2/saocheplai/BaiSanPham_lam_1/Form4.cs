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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Data dulieu = new Data();
        List<SanPham> li = new List<SanPham>();
        

        private void Form4_Load(object sender, EventArgs e)
        {
            li = dulieu.GetDuLieu();
            dataGridView1.DataSource = li;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (li.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào mà xóa !!", "Lỗi");
            }
            else
            {
                SanPham s = new SanPham();
                s.id = txtID.Text;
                int index = li.IndexOf(s);
                if (index == -1)
                {
                    MessageBox.Show("Không có mã sản phẩm này !!", "Lỗi");
                }
                else
                {
                    li.Remove(s);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = li;
                    dulieu.GhiDuLieu(li);

                }
            }

        }
        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            SanPham s = (SanPham)dataGridView1.CurrentRow.DataBoundItem;
            txtID.Text = s.id;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
