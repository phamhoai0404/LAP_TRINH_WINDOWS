using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3_online2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        List<Student> li = new List<Student>();
        private void Form4_Load(object sender, EventArgs e)
        {
            ActiveControl = txtIdStudent;
            dataGVAllStudent.DataSource = li;
            dataGVAllStudent.Columns[0].Width = 50;
            dataGVAllStudent.Columns[1].Width = 250;
            dataGVAllStudent.Columns[2].Width = 50;
            dataGVAllStudent.Columns[3].Width = 150;
            lblNumberStudent.Text = li.Count + "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.id = txtIdStudent.Text;
                s.name = txtNameStudent.Text;
                s.age = int.Parse(txtAge.Text);
                s.address = txtAddress.Text;
                li.Add(s);
                showLi_dataGWStudent();
                deleteTexbox();
            }
            catch
            {
                MessageBox.Show("Tuổi bạn nhập vào không phải là số!", "Thông Báo");
            }
        }
        private void deleteTexbox()
        {
            txtNameStudent.Clear();
            txtIdStudent.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            ActiveControl = txtIdStudent;
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            Stream str = new FileStream("ListStudent.bin", FileMode.Create, FileAccess.Write);
            f.Serialize(str, li);
            str.Close();
            showLi_dataGWStudent();

        }
        private void showLi_dataGWStudent()
        {
            dataGVAllStudent.DataSource = null;
            dataGVAllStudent.DataSource = li;
            lblNumberStudent.Text = li.Count + "";
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream("ListStudent.bin", FileMode.Open, FileAccess.Read);
            li = (List<Student>)f.Deserialize(str);
            str.Close();
            showLi_dataGWStudent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int a = li.Count;
            string ma = txtIdStudent.Text;
            Student s = new Student(ma);
            li.Remove(s);
            showLi_dataGWStudent();
            if (li.Count == a)
            {
                MessageBox.Show("Không có sinh viên nào có mã như vậy! ", "Thông Báo");
            }
            deleteTexbox();

        }

        private void dataGVAllStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Student s = (Student)dataGVAllStudent.CurrentRow.DataBoundItem;
            txtIdStudent.Text = s.id;
            txtNameStudent.Text = s.name;
            txtAge.Text = s.age + "";
            txtAddress.Text = s.address;


        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.id = txtIdStudent.Text;
                s.name = txtNameStudent.Text;
                s.age = int.Parse(txtAge.Text);
                s.address = txtAddress.Text;

                int vitri = li.IndexOf(s);
                li[vitri] = s;
                showLi_dataGWStudent();
            }
            catch 
            {
                MessageBox.Show("Chưa có sinh viên nào !", "Thông Báo");
            }
            
        }
    }
}
