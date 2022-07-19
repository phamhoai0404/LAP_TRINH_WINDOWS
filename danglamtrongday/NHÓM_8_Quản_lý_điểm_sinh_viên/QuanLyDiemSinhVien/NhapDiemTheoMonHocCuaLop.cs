using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class NhapDiemTheoMonHocCuaLop : Form
    {
        public NhapDiemTheoMonHocCuaLop()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void NhapDiemTheoMonHocCuaLop_Load(object sender, EventArgs e)
        {
            this.hienthiDSMonHoc();
            this.hienthiDSLop();
        }
        private void hienthiDSMonHoc()
        {
            combDSMonHoc.DataSource = data.danhsachMonHoc();
            combDSMonHoc.DisplayMember = "tenMonHoc";
            combDSMonHoc.ValueMember = "maMonHoc";
            combDSMonHoc.SelectedValue = "";
        }
        private void hienthiDSLop()
        {
            comLop.DataSource = data.danhsachLopHoc();
            comLop.DisplayMember = "maLop";
            comLop.ValueMember = "maLop";
            comLop.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.hienthiDSMonHoc();
            this.hienthiDSLop();
            
            dataGridView1.Rows.Clear();
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<DiemSinhVien> li = new List<DiemSinhVien>();

            if (combDSMonHoc.Text != "" && comLop.Text != "")
            {
                string malop = comLop.Text + "";
                string mamonhoc = combDSMonHoc.SelectedValue + "";

                DataTable bang = new DataTable();
                bang = data.danhsachSinhVien_nhapDiemLopMon(malop);
               
                dataGridView1.Rows.Clear();
                
                if (bang.Rows.Count != 0)
                {

                    //cho vào li
                    for (int i = 0 ;i < bang.Rows.Count; i++)
                    {
                        DiemSinhVien s = new DiemSinhVien();
                        s.mamonhoc = mamonhoc;
                        s.masv = bang.Rows[i][0].ToString();
                        s.tensv = bang.Rows[i][1].ToString();

                        if (data.kiemtraTonTaiMotDiemCuaSV(s.mamonhoc, s.masv))
                        {
                            DataTable bb = new DataTable();
                            bb = data.diemMaMon_MaSV(s.mamonhoc, s.masv);
                            s.diem = bb.Rows[0][0].ToString();
                        }
                        else
                        {
                            s.diem = "";
                        }
                        

                        li.Add(s);
                    }

                    //Hiển thị 
                    dataGridView1.Rows.Clear();
                    dataGridView1.ColumnCount = 4;

                    int index = 0;
                    foreach (DiemSinhVien item in li)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = item.mamonhoc;
                        dataGridView1.Rows[index].Cells[1].Value = item.masv;
                        dataGridView1.Rows[index].Cells[2].Value = item.tensv;
                        dataGridView1.Rows[index].Cells[3].Value = item.diem;
                        index++;
                    }

                }
                else
                {
                    dataGridView1.Rows.Clear();
                    MessageBox.Show("Lớp không có sinh viên nào !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Phải có đầy đủ mã môn học và mã lớp !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean kiemTraDuLieuDiem(DataGridView dgv)
        {
            int dem = 0;
            int hang = dgv.Rows.Count;
            for (int i = 0; i < hang; i++)
            {
                try
                {
                    if(dgv.Rows[i].Cells[3].Value !=null)//Phải thêm dòng này phòng khi xóa dữ liệu nó báo lỗi
                    {
                        string dd = dgv.Rows[i].Cells[3].Value.ToString();
                        float diem = float.Parse(dd);
                        if (diem >= 0 && diem <= 10)
                        {
                            dem++;
                        }
                        else
                        {
                            MessageBox.Show("Điểm nhập vào >=0 và <=10!", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Điểm nhập vào phải là số !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }    
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Điểm nhập vào phải là số !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
            if (dem == hang) return true;
            return false;
        }

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (kiemTraDuLieuDiem(dataGridView1))
                {
                    data.thuchienThemDiem(dataGridView1);
                    MessageBox.Show("Bạn đã cập nhật điểm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để nhập điểm!", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
