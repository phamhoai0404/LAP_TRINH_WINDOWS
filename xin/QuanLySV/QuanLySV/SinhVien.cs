using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySV
{
    [Serializable]
    class SinhVien
    {
        public string sid { get; set; }
        public string name { get; set; }
        public string phone{ get; set; }
        public string address { get; set; }

        public SinhVien()
        {
            sid = "none";
            name = "none";
            phone = "none";
            address = "none";
        }

        public SinhVien(string sid, string name, string phone, string address)
        {
            this.sid = sid;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public override string ToString()
        {
            return "Ma: " + sid + " - Ten: " + name + " - SDT: " + phone + " - Dia chi: " + address;
        }

        public override bool Equals(object obj)
        {
            SinhVien sv = (SinhVien)obj;
            return this.sid.Equals(sv.sid);
        }
    }
}
