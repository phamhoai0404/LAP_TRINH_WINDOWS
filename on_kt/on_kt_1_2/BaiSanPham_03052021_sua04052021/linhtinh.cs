using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BaiSanPham
{
    class linhtinh
    {
        string filename = "SanPham.bin";
        List<SanPham> li = new List<SanPham>();

        public List<SanPham> getDSSV()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            li = (List<SanPham>)f.Deserialize(stream);
            stream.Close();
            return li;
        }
        public void taofile()
        {
            IFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            f.Serialize(stream, li);
            stream.Close();
            
        }
    }
}
