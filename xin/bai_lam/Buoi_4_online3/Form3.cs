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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public  String userName { get; set; }
        public String  passWord { get; set; }
        public String infor { get; set; }
        private void Form3_Load(object sender, EventArgs e)
        {
            lblName.Text = userName;
            lblPass.Text = passWord;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infor = txtSendForm.Text;
            Close();
        }
    }
}
