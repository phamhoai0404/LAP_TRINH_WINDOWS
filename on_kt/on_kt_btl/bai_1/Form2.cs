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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinhviendbDataSet1.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.sinhviendbDataSet1.sinhvien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sinhvienTableAdapter.Update(this.sinhviendbDataSet1.sinhvien);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sinhviendbDataSet1.sinhvien.DefaultView.RowFilter = "malop ='" + textBox1.Text + "'";
            dataGridView1.DataSource = sinhviendbDataSet1.sinhvien;
        }
    }
}
