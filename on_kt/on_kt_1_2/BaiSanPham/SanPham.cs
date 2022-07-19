using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiSanPham
{
    [Serializable]
    class SanPham
    {
        public string id { get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public double dongia { get; set; }
        public double thanhtien { get; set; }
        public SanPham()
        {

        }
        public SanPham(string id, string tensp, int soluong, double dongia)
        {
            this.id = id;
            this.tensp = tensp;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = this.soluong * this.dongia;

        }
        public override bool Equals(object obj)
        {
            SanPham s = (SanPham)obj;
            return this.id.Equals(s.id);
        }
    }
}
