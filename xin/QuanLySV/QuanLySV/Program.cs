using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySV
{
    class Program
    {
        static List<SinhVien> listStudent = new List<SinhVien>();
        static void Main(string[] args)
        {
            int option = 0;
            string path = "data.bin";
            initial(path);
            do
            {
                Console.WriteLine("\n\n------------------------------------------");
                Console.WriteLine("\t\tDANH SACH TINH NANG");
                Console.WriteLine("1. Doc danh sach sinh vien tu file va hien thi.");
                Console.WriteLine("2. Them 1 sinh vien.");
                Console.WriteLine("3. Chen sinh vien vao vi tri tuy chon.");
                Console.WriteLine("4. Xoa sinh vien.");
                Console.WriteLine("5. Tim kiem sinh vien.");
                Console.WriteLine("6. Sap xep sinh vien va hien thi.");
                Console.WriteLine("7. Hien thi tat ca sinh vien.");
                Console.WriteLine("8. Ghi vao file.");
                Console.WriteLine("9. Ket thuc.");
                Console.WriteLine("----------CHON CHUC NANG-----------");
                Console.Write("Nhap lua chon: ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: 
                        readFile(path);
                        break;
                    case 2:
                        createStudent();
                        break;
                    case 3:
                        insertStudent();
                        break;
                    case 4:
                        deleteStudent();
                        break;
                    case 5:
                        searchStudent();
                        break;
                    case 6:
                        sortStudent();
                        break;
                    case 7:
                        showStudent();
                        break;
                    case 8:
                        writeFile(path);
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Nhap sai lua chon roi!");
                        break;
                }
            } while (option != 9);
        }

        static void initial(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Khong ton tai file!");
                return;
            }
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            listStudent = (List<SinhVien>)formatter.Deserialize(stream);

            stream.Close();
        }

        static void readFile(string path)
        {

            initial(path);
            showStudent();
        }

        static void createStudent()
        {
            Console.WriteLine("\t\tNHAP THONG TIN SINH VIEN");
            Console.Write("Nhap ma sinh vien: ");
            string sid = Console.ReadLine();
            Console.Write("Nhap ten sinh vien: ");
            string name = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string phone = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string address = Console.ReadLine();

            listStudent.Add(new SinhVien(sid, name, phone, address));
        }

        static void insertStudent()
        {
            Console.WriteLine("\t\tNHAP THONG TIN SINH VIEN");
            Console.Write("Nhap ma sinh vien: ");
            string sid = Console.ReadLine();
            Console.Write("Nhap ten sinh vien: ");
            string name = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string phone = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string address = Console.ReadLine();
            Console.WriteLine("\t\tNHAP VI TRI MUON THEM");
            int index = int.Parse(Console.ReadLine());

            listStudent.Insert(index, new SinhVien(sid, name, phone, address));
        }

        static int findStudentByID(string sid)
        {
            for(int i = 0; i < listStudent.Count; i++)
            {
                if(listStudent[i].sid == sid)
                {
                    return i;
                }
            }

            return -1;
        }

        static void deleteStudent()
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string sid = Console.ReadLine();

            int index = findStudentByID(sid);

            if(index == -1)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma la " + sid);
            } 
            else
            {
                listStudent.Remove(listStudent[index]);
                Console.WriteLine("Xoa thanh cong!");
            }
        }

        static void searchStudent()
        {
            Console.Write("Nhap ma sinh vien can tim: ");
            string sid = Console.ReadLine();

            int index = findStudentByID(sid);

            if (index == -1)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma la " + sid);
            }
            else
            {
                Console.WriteLine("------------THONG TIN SINH VIEN-----------");
                Console.WriteLine(listStudent[index]);
            }
        }

        static void sortStudent()
        {
            listStudent.Sort((x, y) => x.sid.CompareTo(y.sid));
            showStudent();
        }

        static void showStudent()
        {
            Console.WriteLine("\t\tDANH SACH SINH VIEN");
            foreach (SinhVien sv in listStudent)
            {
                Console.WriteLine(sv);
            }
        }

        static void writeFile(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, listStudent);

            stream.Close();

            Console.WriteLine("Write file successfully!");
        }
    }
}
