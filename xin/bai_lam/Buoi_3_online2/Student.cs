using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_online2
{
    [Serializable]//cái này là tuần tự dùng để viết vào "*.bin"
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public Student()
        {

        }
        public Student(string ma)
        {
            this.id = ma;

        }
        public override bool Equals(object obj)
        {
            Student s = (Student)obj;
            return (this.id.Equals(s.id));
        }

    }
}
