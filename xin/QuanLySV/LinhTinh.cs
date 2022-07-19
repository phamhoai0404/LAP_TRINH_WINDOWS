using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class LinhTinh
    {
        static List<SinhVien> listStudent = new List<SinhVien>();
        static void docFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File này chua tồn tại");
                return;
            }
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            listStudent = (List<SinhVien>)formatter.Deserialize(stream);
            stream.Close();

        }
        static void vietFile(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, listStudent);
            stream.Close();
        }
        static void Main(string[] arg)
        {
            SinhVien s = new SinhVien();
            SinhVien n = new SinhVien("tine");
            docFile("xinhgai.bin");
            xoaSV();
            listStudent.Add(s);
            listStudent.Add(s);
            listStudent.Add(n);
            hienThiDS();
            xoaSV();
            hienThiDS();
            Console.ReadLine();
        }
        static void hienThiDS()
        {
            Console.WriteLine("danh sanch" );
            foreach (SinhVien item in listStudent)
            {
                Console.WriteLine(item);

            }
        }
        static void chenSV()
        {
            SinhVien s = new SinhVien();
            Console.WriteLine("Nhập vào ten: ");
            s.name = Console.ReadLine();
            Console.WriteLine("thế nhé !: " + s.name);
            listStudent.Add(s);
        }
        static void xoaSV()
        {
            int k = listStudent.Count;
            if (k > 0)
            {
                Console.WriteLine("Vi tri xoa: ");
                int index;
                do
                {
                    try
                    {
                        index = int.Parse(Console.ReadLine());
                        if (!(index <k && index >= 0)) Console.WriteLine("khong co vi tri này");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Phai la so nha !");
                        Console.WriteLine("Nhap lai: ");
                        index = -1;
                    }
                } while (!(index < k && index >= 0));
                Console.WriteLine("day nha: "+k);
                listStudent.Remove(listStudent[index]);
            }
            else
            {
                Console.WriteLine("Không có sinh viên nào !");
            }
        }
    }
}
