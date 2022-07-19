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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       

       
        private void Form2_Load(object sender, EventArgs e)
        {
            Data dulieu = new Data();

            dataGridView1.DataSource = dulieu.GetDuLieu();
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
    }
}
