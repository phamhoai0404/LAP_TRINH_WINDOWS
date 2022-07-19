using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien
{
    class DiemSinhVien
    {
        public string mamonhoc { get; set; }
        public string masv { get; set; }
        public string tensv { get; set; }
        public string diem { get; set; }
        public DiemSinhVien()
        {

        }
        public DiemSinhVien(string mamon, string masv, string tensv, string diem)
        {
            this.mamonhoc = mamon;
            this.masv = masv;
            this.tensv = tensv;
            this.diem = diem;
        }
    }
}
