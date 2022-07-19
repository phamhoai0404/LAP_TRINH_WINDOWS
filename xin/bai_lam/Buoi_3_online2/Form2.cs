using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3_online2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radNam.Checked)
                gt = "Nam";
            else if (radNu.Checked)
                gt = "Nữ";
            string mh = "";
            if (chkJava.Checked)
                mh = "Java";
            if (chkWindows.Checked)
                mh += " Windows";
            lblGhiRa.Text = "Thông tin:" + txtHoTen.Text + ", Giới tính: " + gt + " \n Quê quán: " + cboQueQuan.Text + ", Môn học : " + mh;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
