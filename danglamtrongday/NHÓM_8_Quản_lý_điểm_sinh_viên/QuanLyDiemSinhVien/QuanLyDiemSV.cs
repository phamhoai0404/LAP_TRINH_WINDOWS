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
    public partial class QuanLyDiemSV : Form
    {
        public QuanLyDiemSV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "" || txtTenkhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ tên khoa và mã khoa","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data.themKhoa(txtMakhoa.Text, txtTenkhoa.Text, txtSodienthoai.Text);
                dataGridView2.DataSource = data.danhsachKhoa();
                this.xoaTextBoxKhoa();
            }
        }
        DataUtil data = new DataUtil();


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = data.danhsachSinhVien();
                    this.header_SinhVien();
                    this.hienthiDSKhoa();
                    this.hienthiDSLop();
                    this.hienthiDSMaSV();
                    break;
                case 1:
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = data.danhsachKhoa();
                    this.header_Khoa();
                    ActiveControl = txtMakhoa;
                    break;
                case 2:
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = data.danhsachMonHoc();
                    this.header_MonHoc();
                    this.hienthiDSHocKy();
                    ActiveControl = txtMaMH;
                    break;
                case 3:
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = data.danhsachLopHoc();
                    this.header_Lop();
                    this.hienthiDSKhoa_DSLop();
                    ActiveControl = txtMaLop;
                    break;
                case 4:
                    dataGridView5.DataSource = null;
                    dataGridView5.DataSource = data.danhsachGiangVien();
                    this.header_GiangVien();
                    this.hienthiDSMonHoc();
                    break;
                case 5:
                    dataGridView6.DataSource = null;
                    dataGridView6.DataSource = data.danhsachDiemToanBo();
                    this.header_Diem();
                    break;
                default:
                    break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMakhoa.Text == "" || txtTenkhoa.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ tên khoa và mã khoa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    data.xoaKhoa(txtMakhoa.Text, txtTenkhoa.Text);
                    dataGridView2.DataSource = data.danhsachKhoa();
                    this.xoaTextBoxKhoa();
                }
            }
            catch (Exception ess)
            {
                MessageBox.Show("Có lỗi: "+ ess.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "" || txtTenkhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ tên khoa và mã khoa! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    data.suaKhoa(txtMakhoa.Text, txtTenkhoa.Text, txtSodienthoai.Text);
                    dataGridView2.DataSource = data.danhsachKhoa();
                    this.xoaTextBoxKhoa();
                }
                catch (Exception eeee)
                {

                    MessageBox.Show("Có lỗi" + eeee.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void xoaTextBoxKhoa()
        {
            txtMakhoa.Clear();
            txtSodienthoai.Clear();
            txtTenkhoa.Clear();
            ActiveControl = txtMakhoa;
        }

        private void xoaTextBoxMonHoc()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtSoTC.Clear();
            combHocKy.SelectedIndex = 0;
            ActiveControl = txtMaMH;
        }
        private void xoaTextBoxLop()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSoSinhVien.Clear();
            comKhoaHoc_Lop.SelectedIndex = -1;
            comKhoaDaoTao.SelectedIndex = -1;
            comHeDaoTao.SelectedIndex = -1;
            ActiveControl = txtMaLop;
        }
        private void xoaTextBoxDiemToanBo()
        {
            txtMaSVDiem.Clear();
            txtMaMonDiem.Clear();
            txtHotenSVDiem.Clear();
            txtDiem.Clear();
            ActiveControl = txtMaMonDiem;
        }
        private void header_SinhVien()
        {
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Quê quán";
            dataGridView1.Columns[5].HeaderText = "Mã lớp";
            dataGridView1.Columns[6].HeaderText = "Mã khoa";
            dataGridView1.Columns[7].HeaderText = "Khóa học";
            dataGridView1.Columns[8].HeaderText = "Điểm trung bình";

            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[8].Width = 60;
        }
        private void header_Khoa()
        {
            dataGridView2.Columns[0].HeaderText = "Mã khoa";
            dataGridView2.Columns[1].HeaderText = "Tên khoa";
            dataGridView2.Columns[2].HeaderText = "Điện thoại liên hệ";

            dataGridView2.Columns[0].Width = 150;
            dataGridView2.Columns[1].Width = 300;
        }
        private void header_MonHoc()
        {
            dataGridView3.Columns[0].HeaderText = "Mã môn học";
            dataGridView3.Columns[1].HeaderText = "Tên môn học";
            dataGridView3.Columns[2].HeaderText = "Số tín chỉ";
            dataGridView3.Columns[3].HeaderText = "Mã học kì";

            dataGridView3.Columns[1].Width = 300;
        }
        private void header_Lop()
        {
            dataGridView4.Columns[0].HeaderText = "Mã lớp";
            dataGridView4.Columns[1].HeaderText = "Tên lớp";
            dataGridView4.Columns[2].HeaderText = "Hệ đào tạo";
            dataGridView4.Columns[3].HeaderText = "Khóa";
            dataGridView4.Columns[4].HeaderText = "Sĩ số";
            dataGridView4.Columns[5].HeaderText = "Mã khoa";

            dataGridView4.Columns[0].Width = 120;
            dataGridView4.Columns[1].Width = 200;
            dataGridView4.Columns[2].Width = 100;
            dataGridView4.Columns[3].Width = 60;
            dataGridView4.Columns[4].Width = 60;
        }
        private void header_GiangVien()
        {
            dataGridView5.Columns[0].HeaderText = "Mã giảng viên";
            dataGridView5.Columns[1].HeaderText = "Họ tên";
            dataGridView5.Columns[2].HeaderText = "Ngày sinh";
            dataGridView5.Columns[3].HeaderText = "Giới tính";
            dataGridView5.Columns[4].HeaderText = "Email";
            dataGridView5.Columns[5].HeaderText = "Quê quán";
            dataGridView5.Columns[6].HeaderText = "Năm bắt đầu công tác";

            dataGridView5.Columns[0].Width = 120;
            dataGridView5.Columns[1].Width = 250;
            dataGridView5.Columns[3].Width = 70;
        }
        private void header_Diem()
        {
            dataGridView6.Columns[0].HeaderText = "Mã môn học";
            dataGridView6.Columns[1].HeaderText = "Mã sinh viên";
            dataGridView6.Columns[2].HeaderText = "Họ tên";
            dataGridView6.Columns[3].HeaderText = "Điểm";

            dataGridView6.Columns[1].Width = 160;
            dataGridView6.Columns[2].Width = 200;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMakhoa.Text = dataGridView2.Rows[hang].Cells[0].Value.ToString();
                txtTenkhoa.Text = dataGridView2.Rows[hang].Cells[1].Value.ToString();
                txtSodienthoai.Text = dataGridView2.Rows[hang].Cells[2].Value.ToString();

            }
            catch (Exception r)
            {

                MessageBox.Show("Có lỗi xảy ra " + r.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void hienthiDSHocKy()
        {
            combHocKy.DataSource = data.danhsachHocKy();
            combHocKy.DisplayMember = "tenHocKy";
            combHocKy.ValueMember = "maHocKy";

        }
        private void hienthiDSKhoa()
        {
            comKhoaQuanLy.DataSource = data.danhsachKhoa();
            comKhoaQuanLy.DisplayMember = "tenKhoa";
            comKhoaQuanLy.ValueMember = "maKhoa";
            comKhoaQuanLy.SelectedIndex = -1;
        }
        private void hienthiDSKhoa_DSLop()
        {
            comKhoaDaoTao.DataSource = data.danhsachKhoa();
            comKhoaDaoTao.DisplayMember = "tenKhoa";
            comKhoaDaoTao.ValueMember = "maKhoa";
            comKhoaDaoTao.SelectedIndex = -1;
        }
        private void hienthiDSLop()
        {
            comLop.DataSource = data.danhsachLopHoc();
            comLop.DisplayMember = "maLop";
            comLop.ValueMember = "maLop";
            comLop.SelectedIndex = -1;
        }
        private void hienthiDSMaSV()
        {
            comMaSV.DataSource = data.danhsachSinhVien();
            comMaSV.DisplayMember = "maSV";
            comMaSV.ValueMember = "maSV";
            comMaSV.SelectedIndex = -1;
        }
        private void hienthiDSMonHoc()
        {
            combDSMonHoc.DataSource = data.danhsachMonHoc();
            combDSMonHoc.DisplayMember = "tenMonHoc";
            combDSMonHoc.ValueMember = "maMonHoc";
            combDSMonHoc.SelectedIndex = -1;
        }
        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã môn học !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MonHoc s = new MonHoc();
                s.maMH = txtMaMH.Text;
                data.xoaMonHoc(s);
                dataGridView3.DataSource = data.danhsachMonHoc();
                this.xoaTextBoxMonHoc();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaMH.Text = dataGridView3.Rows[hang].Cells[0].Value.ToString();
                txtTenMH.Text = dataGridView3.Rows[hang].Cells[1].Value.ToString();
                txtSoTC.Text = dataGridView3.Rows[hang].Cells[2].Value.ToString();
                combHocKy.SelectedValue = dataGridView3.Rows[hang].Cells[3].Value.ToString();

            }
            catch (Exception r)
            {

                MessageBox.Show("Có lỗi xảy ra " + r.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTC.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MonHoc s = new MonHoc();
                s.maMH = txtMaMH.Text;
                s.tenMH = txtTenMH.Text;
                try
                {
                    s.sotc = int.Parse(txtSoTC.Text);
                    if (s.sotc <= 8 && s.sotc >= 1)
                    {
                        s.maHocKy = combHocKy.SelectedValue + "";
                        data.themMonHoc(s);
                        dataGridView3.DataSource = data.danhsachMonHoc();
                        this.xoaTextBoxMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Số tín chỉ >=1 và <=8  !!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Số tín chỉ nhập vào phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTC.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MonHoc s = new MonHoc();
                    s.maMH = txtMaMH.Text;
                    s.tenMH = txtTenMH.Text;
                    try
                    {
                        s.sotc = int.Parse(txtSoTC.Text);
                        if (s.sotc <= 8 && s.sotc >= 1)
                        {
                            s.maHocKy = combHocKy.SelectedValue + "";
                            data.suaMonHoc(s);
                            dataGridView3.DataSource = data.danhsachMonHoc();
                            this.xoaTextBoxMonHoc();
                        }
                        else
                        {
                            MessageBox.Show("Số tín chỉ >=1 và <=8  !!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Số tín chỉ nhập vào phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception eeee)
                {

                    MessageBox.Show("Lỗi " + eeee.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }








        private void QuanLyDiemSV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.danhsachSinhVien();
            this.header_SinhVien();
            this.hienthiDSKhoa();
            this.hienthiDSLop();
            this.hienthiDSMaSV();
        }

        private void btnDanhSachBanDau_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.danhsachSinhVien();
            this.hienthiDSKhoa();
            this.hienthiDSLop();
            this.hienthiDSMaSV();
            this.header_SinhVien();
            combHocKy.SelectedIndex = -1; ;
            comKhoaQuanLy.SelectedIndex = -1;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.timKiemSinhVien(comKhoaQuanLy.Text, comLop.Text, comMaSV.Text);
            this.header_SinhVien();
        }

        private void danhSáchSinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSinhVienTheoLop f1 = new DanhSachSinhVienTheoLop();
            f1.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                string a = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                ThongTinChiTietSinhVien f1 = new ThongTinChiTietSinhVien();
                f1.masv = a;
                f1.ShowDialog();
            }
            catch (Exception r)
            {
                MessageBox.Show("Có lỗi xảy ra " + r.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                string a = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                ThongTinChiTietSinhVien f1 = new ThongTinChiTietSinhVien();
                f1.masv = a;
                f1.ShowDialog();


            }
            catch (Exception r)
            {

                MessageBox.Show("Có lỗi xảy ra " + r.Message);
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã môn học trước khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Lop s = new Lop();
                s.malop = txtMaLop.Text;
                data.xoaLop(s);
                dataGridView4.DataSource = data.danhsachLopHoc();
                this.xoaTextBoxLop();
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "" || txtTenLop.Text == "" || txtSiSoSinhVien.Text == "" || comHeDaoTao.Text == "" || comKhoaHoc_Lop.Text == "" || comKhoaDaoTao.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Lop s = new Lop();
                s.malop = txtMaLop.Text;
                s.tenlop = txtTenLop.Text;
                s.khoahoc = comKhoaHoc_Lop.Text;
                s.hedaotao = comHeDaoTao.Text;
                s.makhoa = comKhoaDaoTao.SelectedValue + "";
                try
                {
                    s.siso = int.Parse(txtSiSoSinhVien.Text);
                    if (s.siso >= 10 && s.siso <= 120)
                    {
                        data.themLop(s);
                        dataGridView4.DataSource = data.danhsachLopHoc();
                        this.xoaTextBoxLop();
                    }
                    else
                    {
                        MessageBox.Show("Sĩ số của lớp >=10 && <=120  !!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Sĩ số lớp nhập vào phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaLop.Text = dataGridView4.Rows[hang].Cells[0].Value.ToString();
                txtTenLop.Text = dataGridView4.Rows[hang].Cells[1].Value.ToString();
                txtSiSoSinhVien.Text = dataGridView4.Rows[hang].Cells[4].Value.ToString();
                comHeDaoTao.Text = dataGridView4.Rows[hang].Cells[2].Value.ToString();
                comKhoaHoc_Lop.Text = dataGridView4.Rows[hang].Cells[3].Value.ToString();
                comKhoaDaoTao.SelectedValue = dataGridView4.Rows[hang].Cells[5].Value.ToString();
            }
            catch (Exception r)
            {

                MessageBox.Show("Có lỗi xảy ra " + r.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "" || txtTenLop.Text == "" || txtSiSoSinhVien.Text == "" || comHeDaoTao.Text == "" || comKhoaHoc_Lop.Text == "" || comKhoaDaoTao.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Lop s = new Lop();
                s.malop = txtMaLop.Text;
                s.tenlop = txtTenLop.Text;
                s.khoahoc = comKhoaHoc_Lop.Text;
                s.hedaotao = comHeDaoTao.Text;
                s.makhoa = comKhoaDaoTao.SelectedValue + "";
                try
                {
                    s.siso = int.Parse(txtSiSoSinhVien.Text);
                    if (s.siso >= 10 && s.siso <= 120)
                    {
                        data.suaLop(s);
                        dataGridView4.DataSource = data.danhsachLopHoc();
                        this.xoaTextBoxLop();
                    }
                    else
                    {
                        MessageBox.Show("Sĩ số của lớp >=10 && <=120  !!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Sĩ số lớp nhập vào phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            if (combDSMonHoc.Text == "")
            {
                MessageBox.Show("Bạn chưa điền tên môn học !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string k = combDSMonHoc.SelectedValue + "";
                // MessageBox.Show("Lỗi " + k );
                dataGridView5.DataSource = data.timKiemGiangVienTheoMon(k);
            }
        }

        private void btnDSGiangVienBanDau_Click(object sender, EventArgs e)
        {
            //dataGridView5.DataSource = null;
            dataGridView5.DataSource = data.danhsachGiangVien();
            combDSMonHoc.SelectedIndex = -1;
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                string a = dataGridView5.Rows[hang].Cells[0].Value.ToString();
                ThongTinChiTietGiangVien f1 = new ThongTinChiTietGiangVien();
                f1.maGV = a;
                f1.ShowDialog();


            }
            catch (Exception r)
            {

                MessageBox.Show("Có lỗi xảy ra " + r.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void danhSáchMônHọcTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachMonHocTheoLop f1 = new DanhSachMonHocTheoLop();
            f1.ShowDialog();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }



        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            if (txtMaMonDiem.Text == "" || txtMaSVDiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập để thông tin tối thiểu để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    float diem = float.Parse(txtDiem.Text);
                    if (diem >= 0 && diem <= 10)
                    {
                        data.suaDiemMHSV(txtMaMonDiem.Text, txtMaSVDiem.Text, diem);
                        dataGridView6.DataSource = data.danhsachDiemToanBo();
                        this.xoaTextBoxDiemToanBo();
                    }
                    else
                    {
                        MessageBox.Show("Điểm phải >=0 và <=10 !!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Điểm nhập vào phải là số  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMonDiem.Text == "" || txtMaSVDiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập để thông tin tối thiểu để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    data.xoaDiemTrongBang(txtMaMonDiem.Text, txtMaSVDiem.Text);
                    dataGridView6.DataSource = data.danhsachDiemToanBo();
                    this.xoaTextBoxDiemToanBo();
                }
            }
            catch (Exception em)
            {
                MessageBox.Show("Có lỗi" + em.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaMonDiem.Text = dataGridView6.Rows[hang].Cells[0].Value.ToString();
                txtMaSVDiem.Text = dataGridView6.Rows[hang].Cells[1].Value.ToString();
                txtHotenSVDiem.Text = dataGridView6.Rows[hang].Cells[2].Value.ToString();
                txtDiem.Text = dataGridView6.Rows[hang].Cells[3].Value.ToString();

            }
            catch (Exception r)
            {
                MessageBox.Show("Có lỗi xảy ra " + r.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSinhVienTheoLop f1 = new DanhSachSinhVienTheoLop();
            f1.ShowDialog();
        }

        private void danhSáchMônHọcTheoLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhSachMonHocTheoLop f1 = new DanhSachMonHocTheoLop();
            f1.ShowDialog();
        }

        private void comKhoaQuanLy_SelectedValueChanged(object sender, EventArgs e)
        {
            string k = comKhoaQuanLy.SelectedValue + "";

            //comLop
            comLop.DataSource = data.timKiem_Lop_TheoMaKhoa(k);
            comLop.DisplayMember = "maLop";
            comLop.ValueMember = "maLop";
            comLop.SelectedIndex = -1;
            //comSinhVien
            comMaSV.DataSource = data.timKiem_MaSinhVien_TheoMaKhoa(k);
            comMaSV.DisplayMember = "maSV";
            comMaSV.ValueMember = "maSV";
            comMaSV.SelectedIndex = -1;
        }

        private void comLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string k = comLop.SelectedValue + "";
            comMaSV.DataSource = data.timKiem_MaSinhVien_TheoMaLop(k);
            comMaSV.DisplayMember = "maSV";
            comMaSV.ValueMember = "maSV";
            comMaSV.SelectedIndex = -1;
        }

        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemSinhVien f1 = new TimKiemSinhVien();
            f1.ShowDialog();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiemTheoMonHocCuaLop f1 = new NhapDiemTheoMonHocCuaLop();
            f1.ShowDialog();
            dataGridView6.DataSource = data.danhsachDiemToanBo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void combDSMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
