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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                lstRight.Items.Add(lstLeft.SelectedItem);
                lstLeft.Items.Remove(lstLeft.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Bạn phải chọn một mục bên trái !", "Lỗi");
            }


        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                lstLeft.Items.Add(lstRight.SelectedItem);
                lstRight.Items.Remove(lstRight.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Bạn phải chọn một mục bên phải!", "Lỗi");
            }

        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            if (lstLeft.Items.Count == 0)
            {
                MessageBox.Show("Bên trái không còn mục nào mà chọn !", "Lỗi");
            }
            else
            {
                lstRight.Items.AddRange(lstLeft.Items);
                lstLeft.Items.Clear();
            }

        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            if (lstRight.Items.Count == 0)
            {
                MessageBox.Show("Bên phải không còn mục nào mà chọn !", "Lỗi");
            }
            else
            {
                lstLeft.Items.AddRange(lstRight.Items);
                lstRight.Items.Clear();
            }

        }
    }
}
