using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi_5
{

    public partial class Form1 : Form
    {
        public double ketqua { get; set; }
        public String tinh = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblBang.Text = "";
            if (txtManHinh.Text == "0")
                txtManHinh.Clear();

            Button b = (Button)sender;
            if (txtManHinh.Text.Length >= 2)
            {
                String k = txtManHinh.Text.Substring(txtManHinh.Text.Length - 1);
                if (k == "/" && b.Text == "0")
                {
                    MessageBox.Show("Không thể chia cho 0!", "Error");
                }
                else
                {
                    txtManHinh.Text += b.Text;

                }
            }
            else
            {
                txtManHinh.Text += b.Text;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            String k = txtManHinh.Text.Substring(txtManHinh.Text.Length - 1);
            if (k == "+" || k == "-" || k == "*" || k == "/")
            {
                MessageBox.Show("Vẫn còn một phép tính kìa !", "Error");
            }
            else
            {
                lblBang.Text = txtManHinh.Text + " = ";

                txtManHinh.Text = tinhsss(txtManHinh.Text) + "";

            }
        }
        private double tinhsss(string str)//Mình viết cái hàm này là dùng cho bất kì chữ kí tự nào 
        {
            string[] arrListStr = str.Split(new char[] { '+', '-', '*', '/' });
            int j;

            double kq = 0;
            if (str[0] == '-')
            {
                j = 1;
                kq = -double.Parse(arrListStr[j++]);
            }
            else
            if (str[0] == '+')
            {
                j = 1;
                kq = double.Parse(arrListStr[j++]);
            }
            else
            {
                j = 0;
                kq = double.Parse(arrListStr[j++]);
            }


            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '+') kq += double.Parse(arrListStr[j++]);
                else if (str[i] == '-') kq -= double.Parse(arrListStr[j++]);
                else if (str[i] == '*') kq *= double.Parse(arrListStr[j++]);
                else if (str[i] == '/') kq /= double.Parse(arrListStr[j++]);
                // if (j == arrListStr.Length) break;

            }
            return kq;

        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";
            lblBang.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = txtManHinh.Text.Remove(txtManHinh.Text.Length - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblBang.Text = "";
            Button b = (Button)sender;
            if (txtManHinh.Text == "0")
            {
                if (b.Text == "-" || b.Text == "+")
                {
                    txtManHinh.Text = b.Text;
                }
                else
                {
                    MessageBox.Show("Chưa có  con số nào vui lòng chọn lại!", "Error");
                }
            }
            else
            {
                String k = txtManHinh.Text.Substring(txtManHinh.Text.Length - 1);
                if (k == "+" || k == "-" || k == "*" || k == "/")
                {
                    MessageBox.Show("Không thể hai phép tính linh tinh như vậy!", "Error");
                }
                else
                {

                    txtManHinh.Text += b.Text;

                }
            }
        }


    }
}

