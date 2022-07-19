using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiSanPham
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        Data dulieu = new Data();
        List<SanPham> li = new List<SanPham>();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            if (li.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào mà tìm kiếm !!", "Lỗi");
            }
            else
            {
                SanPham s = new SanPham();
                s.id = txtID.Text;
                int index = li.IndexOf(s);
                if (index == -1)
                {
                    MessageBox.Show("Không có mã sản phẩm này để tìm kiếm !!", "Lỗi");
                }
                else
                {
                    MessageBox.Show("Đã đi vào đây " + index);

                    List<SanPham> li2 = new List<SanPham>();//tại vì không biết tại sao lại không ghi trực tiếp là dataGridView1.DataSource = li[index] như thế này được nên mới tạo ra một li2 để cho nó vào đấy
                    li2.Add(li[index]);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = li2;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            li = dulieu.GetDuLieu();
            dataGridView1.DataSource = li;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }
    }
}
