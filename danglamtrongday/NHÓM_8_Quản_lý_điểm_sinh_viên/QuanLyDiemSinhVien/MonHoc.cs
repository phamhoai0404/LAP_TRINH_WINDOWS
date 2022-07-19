using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien
{
    class MonHoc
    {
        public String  maMH{ get; set; }
        public String tenMH { get; set; }
        public int sotc { get; set; }
        public String maHocKy { get; set; }
        public MonHoc()
        {

        }
        public MonHoc(String ma, String ten, int sotc,String maHK)
        {
            this.maMH = ma;
            this.tenMH = ten;
            this.sotc = sotc;
            this.maHocKy = maHK;
        }
    }
}
