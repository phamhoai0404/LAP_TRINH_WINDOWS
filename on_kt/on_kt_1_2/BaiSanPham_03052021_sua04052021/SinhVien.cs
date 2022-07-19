using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiSanPham
{
    [Serializable]
    class SinhVien
    {
        public string id { get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public double dongia { get; set; }
        public double  thanhtien { get; set; }
        public SinhVien()
        {

        }
        public override bool Equals(object obj)
        {
            SinhVien s = (SinhVien)obj;
            return this.id.Equals(s.id);
        }
    }
}
