using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
// tại sao lại có màu đậm và màu nhạt thì mình hiểu rồi : màu đậm là cái thư viện này đã được sử dụng còn nhạt là cái thư viện này chưa được sử dụng


namespace ConsoleApp2
{
    class ReadWriteObjectFile
    {
        static void Main(string[] arg)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            DocGhiDoiTuongFile();//đọc ghi đối tượng trong file
            //CollectionDoNha();//List các kiểu đấy
            Console.ReadLine();
        }
        public static void CollectionDoNha()
        {
            //TEST LIST COLLECTION
            List<Student> ds = new List<Student>();

            AddList___(ds);//thêm vào đối tượng trong danh sách
            FindList___(ds);//tìm kiếm dối tượng trong danh sách

            ds.RemoveAt(3);//xóa đối tượng ở phần tử thứ ...
            Console.WriteLine("\n----\nSau khi xoa phan tu thu 2: ");
            ShowList___(ds);

            ds.Insert(1, new Student("s6", "Mai", 8, "mai@gmail.com"));//chèn vào phần tử thứ....
            Console.WriteLine("\n----\nSau khi them vao vi tri so 1: ");
            ShowList___(ds);

            ds.Sort();//sắp xếp danh sách theo dựa vào CompareTo() đã định nghĩa ở phần Class Student
            Console.WriteLine("\n----\nSau khi sap xep danh sach: ");
            ShowList___(ds);
        }
        public static void AddList___(List<Student> ds)
        {
            ds.Add(new Student("s1", "Anh", 9, "anh@gmail.com"));
            ds.Add(new Student("s2", "Tuan", 1, "tuananh@gmail.com"));
            ds.Add(new Student("s3", "Long", 3, "long@gmail.com"));
            ds.Add(new Student("s4", "Hai", 7, "hai@gmail.com"));
            ShowList___(ds);
        }
        public static void FindList___(List<Student> ds)
        {
            Console.WriteLine("Nhập vào mã sinh viên cần tìm kiếm: ");
            string maTest = Console.ReadLine();

            Student x = new Student(maTest);
            int vitri = ds.IndexOf(x);//Trả về vị trí đầu tiên xuất hiện đối tượng Value trong List.Nếu không tìm thấy sẽ trả về - 1
            if (vitri != -1)
            {
                x = ds[vitri];
                Console.WriteLine("\nKet qua tim kiem o vi tri : " + vitri);
                Console.WriteLine("Sv can tim la: " + x);
            }
            else
            {
                Console.WriteLine("\n Không sinh viên nào có mã " + maTest);
            }
        }
        public static void ShowList___(List<Student> ds)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }
        }
        public static void DocGhiDoiTuongFile()
        {
            string filename = "student.bin";//theo mình  tra và nhớ mang máng cô nói thì file này dùng để ghi mã hóa thông tin
            Write___(filename);//hàm đọc viết file thôi mà tự tạo ấy 
            Read___(filename);
        }
        public static void Write___(string filename)
        {
            Student s1 = new Student("s1", "Mai Anh", 8, "anhmai@gmail.com");
            Student s2 = new Student("s2", "Van Tuan", 5, "tuananh@gmail.com");
            List<Student> li = new List<Student>();
            li.Add(s1);
            li.Add(s2);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);


            //một list hay một đối tượng thì cũng thế nhể?!
            formatter.Serialize(stream, li);//Serialize: tra tiếng anh có nghĩa là nối tiếp. theo mình nghĩ nó là tuần tự
            //formatter.Serialize(stream, s2);**dòng này là cô làm đấy chứ không phải mình thêm vào đâu
            stream.Close();

        }
        public static void Read___(string filename)
        {
            //Một list
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);

            List<Student> li = new List<Student>();
            li = (List<Student>)formatter.Deserialize(stream);
            foreach (Student item in li)
            {
                Console.WriteLine(item);

            }

            //Một Object bình thường thường
            // Student s2;
            // s2 = (Student)formatter.Deserialize(stream);
            //Console.WriteLine(s2);

            stream.Close();
        }
    }
}