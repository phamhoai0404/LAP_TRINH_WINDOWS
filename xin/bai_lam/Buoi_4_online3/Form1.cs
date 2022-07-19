using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linhtinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private OpenFileDialog ofiledg;// mở cái file đấy 
        private SaveFileDialog sfiledg;// lưu cái file đấy
        private FontDialog fontdg;
        private ColorDialog colordg;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            this.Text = "Untitle Text";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofiledg = new OpenFileDialog();
            if (ofiledg.ShowDialog() == DialogResult.OK)
            {
                txtContent.Text = File.ReadAllText(ofiledg.FileName);
                this.Text = ofiledg.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileNew();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "Untitle Text")//đầu tiên sẽ luôn có tên như này khi lưu vào mặc dù nó là Untitle Text nhưng nó vẫn khác tại vì đường dẫn khác. ok nha hahhahaha
            {
                File.WriteAllText(ofiledg.FileName, txtContent.Text);//viết lại hay còn gọi là lưu lại thì phải lưu ở cái file đang mở chứ
            }
            else
            {
                saveFileNew();
            }

        }
        private void saveFileNew()
        {
            sfiledg = new SaveFileDialog();
            sfiledg.Filter = "Text Document(*.txt)|*.txt";
            if (sfiledg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfiledg.FileName, txtContent.Text);
                this.Text = sfiledg.FileName;
            }
        }

        private void inforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phạm Thị Hoài Năm 3 Trường: HaUI 3/3/2021", "Information Author");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontdg = new FontDialog();
            if (fontdg.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = fontdg.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colordg = new ColorDialog();
            if (colordg.ShowDialog() == DialogResult.OK)
            {
                txtContent.ForeColor = colordg.Color;

            }
        }
        private void Unrealized()
        {
            MessageBox.Show("Chưa làm được !","Thông báo" );
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unrealized();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unrealized();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unrealized();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unrealized();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unrealized();
        }
    }
}

