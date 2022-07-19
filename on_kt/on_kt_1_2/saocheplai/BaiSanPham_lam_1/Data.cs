using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BaiSanPham
{
    class Data
    {
        string file = "SanPham.bin";
        List<SanPham> li = new List<SanPham>();
        public List<SanPham> GetDuLieu()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                   li = (List<SanPham>)f.Deserialize(str);
            }
            catch
            {
                //kiểu cho try catch vào nếu nó chưa có gì thì thôi
            }    
            str.Close();
            return li;
        }
        
        public void AddDuLieu(SanPham s)//cái này không cần thiết nếu cho vào sẽ khó hiểu -->tóm lại không cần 
        {
            if(File.Exists(file))
            {
                li = this.GetDuLieu();
            }
            li.Add(s);
            this.TaoFile();
        }
        public void TaoFile()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream str = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            f.Serialize(str, li);
            str.Close();
        }
        public void GhiDuLieu(List<SanPham> z)
        {
            li = z;
            this.TaoFile();
        }
        
    }
}
