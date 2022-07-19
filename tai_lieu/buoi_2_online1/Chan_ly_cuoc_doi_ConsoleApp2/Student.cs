using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    class Student : IComparable<Student>//cho thêm cái IComparable<Student> dành cho cái sắp xếp ở ds.Sort() ấy 
    {
        public string id{ get; set; }
        public string name{ get; set; }
        public int mark{ get; set; }
        public string email { get; set; }

        public Student()
        {

        }
        public Student(string id, string name, int mark, string email)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            this.email = email;

        }
        public Student(string id)
        {
            this.id = id;
        }


        // dùng để ghi ra ví dụ: Student s=.... thì ghi ra khi viết là  Console.WriteLine("Sinh viên đó là : "+s);
        public override string ToString()
        {
            return id + ", " + name + ", " + mark + ", " + email;
        }

        //phải tìm hiểu dài dài nhá bạn mã sinh viên bằng nhau thì hai sinh viên này là một thế nhé hahah(3 lần mới chốt ra được câu này xem video của cô)
        public override bool Equals(object obj)
        {
            Student s = (Student)obj;
            return (this.id.Equals(s.id));
        }

        //dùng để ds.Sort(); sắp xếp danh sách theo   id      kia kìa có nhìn thấy không
        public int CompareTo(Student other)
        {
            // return (this.mark - other.mark);
            return (this.id.CompareTo(other.id));
        }
    }
}
