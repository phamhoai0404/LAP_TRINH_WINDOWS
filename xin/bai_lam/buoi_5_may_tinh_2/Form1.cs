using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi_5_may_tinh_2
{
    public partial class Form1 : Form
    {
        //có đi tham khảo làm 2 ngày hai đêm. cũng tạm được. còn lần trước là tách xâu
        public double soMot { get; set; }
        public double soHai { get; set; }
        public string phepTinh = "";
        //public bool G = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (txtManHinh.Text == "0")
                txtManHinh.Clear();
            if (lblBang.Text.IndexOf('=') != -1)
                lblBang.Text = "";
            Button b = (Button)sender;
            if (b.Text == ".")
                txtManHinh.Text += b.Text;
            else
            {
                txtManHinh.Text += b.Text;
                txtManHinh.Text = dauPhay(txtManHinh.Text);
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            phepTinh = b.Text;
            if (txtManHinh.Text != "")
            {
                try
                {
                    soMot = double.Parse(txtManHinh.Text);
                    lblBang.Text = txtManHinh.Text + phepTinh;
                    txtManHinh.Clear();
                }
                catch
                {
                    MessageBox.Show("Không có số như này !", "Error");
                }
            }
            else
            {
                lblBang.Text = soMot + phepTinh;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";
            lblBang.Text = "";
            soHai = 0;
            soMot = 0;
            phepTinh = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //tạo ra bool G dùng để tác dụng cái lblBang trong trường hợp có nhiều dấu chấm vd 12.32.233 thì nó sẽ báo lỗi 
            //và mình xóa đi thì cái lblBang.Text nó vẫn giữ nguyên
            //if (G)
            //{
            //lblBang.Text = "";
            //}
            if (lblBang.Text.IndexOf('=') != -1)
                lblBang.Text = "";
            txtManHinh.Text = txtManHinh.Text.Remove(txtManHinh.Text.Length - 1);
            txtManHinh.Text = dauPhay(txtManHinh.Text);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (lblBang.Text.IndexOf('=') == -1)
            {
                if (phepTinh == "")
                {
                    MessageBox.Show(" Lỗi nhá ! ", "Error");
                }
                else
                {
                    try
                    {
                        soHai = double.Parse(txtManHinh.Text);
                        if (soHai == 0 && phepTinh == "/")
                        {
                            MessageBox.Show("Không được chia cho không nhá !", "Error");
                        }
                        else
                        {
                            string k;
                            lblBang.Text += dauPhay(txtManHinh.Text) + " = ";
                            if (phepTinh == "+") k = soMot + soHai + "";
                            else if (phepTinh == "-") k = soMot - soHai + "";
                            else if (phepTinh == "*") k = soMot * soHai + "";
                            else k = soMot / soHai + "";
                            txtManHinh.Text = dauPhay(k);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không có số nào như vậy cả", "Error");
                    }
                }

            }

        }

        private string dauPhay(string k)
        {
            try
            {
                double j = double.Parse(k);//
                k = j + "";// hai cái dòng này là mục đích xóa hết dấu phẩy cũ đi để thiết lập dấu phẩy mới
                string s = "", n = "";
                int u = k.IndexOf('.');
                if (j >= 0)
                {

                    if (u == -1)
                    {
                        int z = 3;
                        for (int i = k.Length - 1; i >= 0; i--)
                        {
                            z--;
                            if (z == 0 && i != 0)
                            {
                                s += k[i] + ",";
                                z = 3;
                            }
                            else s += k[i];
                        }
                    }
                    else
                    {
                        int z = 3;
                        for (int i = k.Length - 1; i >= 0; i--)
                        {
                            if (i >= u) s += k[i];
                            else
                            {
                                z--;
                                if (z == 0 && i != 0)
                                {
                                    s += k[i] + ",";
                                    z = 3;
                                }
                                else s += k[i];
                            }
                        }
                    }
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        n += s[i];
                    }
                }
                else
                {

                    if (u == -1)
                    {
                        int z = 3;
                        for (int i = k.Length - 1; i >= 1; i--)
                        {
                            z--;
                            if (z == 0 && i != 1)
                            {
                                s += k[i] + ",";
                                z = 3;
                            }
                            else s += k[i];
                        }
                    }
                    else
                    {
                        int z = 3;
                        for (int i = k.Length - 1; i >= 1; i--)
                        {
                            if (i >= u) s += k[i];
                            else
                            {
                                z--;
                                if (z == 0 && i != 1)
                                {
                                    s += k[i] + ",";
                                    z = 3;
                                }
                                else s += k[i];
                            }
                        }
                    }
                    s += "-";
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        n += s[i];
                    }

                }
                return n;
            }
            catch
            {

                MessageBox.Show("Không phai là số !", "Error");
                return k;
            }


        }
    }
}
