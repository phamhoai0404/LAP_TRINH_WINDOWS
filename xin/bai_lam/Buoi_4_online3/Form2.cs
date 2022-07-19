using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linhtinh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if((txtName.Text == txtPass.Text) && (txtName.Text !=""))
            {

                if (txtName.Text == "haihai")
                {
                    MessageBox.Show("Chào mừng bạn đến với thế giới của chúng tôi !!!", "Chào mừng");
                    Form3 f3 = new Form3();
                    f3.userName = txtName.Text;
                    f3.passWord = txtPass.Text;
                    f3.ShowDialog();
                    lblMessage.Text = f3.infor;
                }
                else
                {
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai!!!!!!!!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtName.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
