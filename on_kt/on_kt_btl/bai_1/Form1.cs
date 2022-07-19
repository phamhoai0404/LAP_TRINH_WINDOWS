using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinhviendbDataSet.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.sinhviendbDataSet.sinhvien);
            // TODO: This line of code loads data into the 'sinhviendbDataSet.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.sinhviendbDataSet.sinhvien);
            // TODO: This line of code loads data into the 'sinhviendbDataSet.lophoc' table. You can move, or remove it, as needed.
      //      this.lophocTableAdapter.Fill(this.sinhviendbDataSet.lophoc);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            sinhvienTableAdapter.Update(this.sinhviendbDataSet.sinhvien);
            MessageBox.Show("Được cập nhật thành công !!!!!!");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sinhviendbDataSet.sinhvien.DefaultView.RowFilter = string.Format("malop={0}", txtLocMa.Text);
            sinhviendbDataSet.sinhvien.DefaultView.RowFilter = "masv= '" + txtLocMa.Text + "'";//cái cần phải trùng với tên ở datagridview cái phần edit ấy và không phân biệt chữ hoa chữ thường
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sinhviendbDataSet.sinhvien;
        }
    }
}
