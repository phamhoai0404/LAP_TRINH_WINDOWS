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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        List<SanPham> li = new List<SanPham>();


        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void readFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void addProductFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
