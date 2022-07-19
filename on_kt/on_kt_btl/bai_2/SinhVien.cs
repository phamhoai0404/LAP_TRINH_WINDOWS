using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class SinhVien
    {
        public int masv { get; set; }
        public String hoten { get; set; }
        public String diachi { get; set; }
        public String dienthoai { get; set; }
        public int malop { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(int ma, String hoten,String diachi, String dienthoai, int malop)
        {
            this.masv = ma;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.malop = malop;
        }
    }
}
