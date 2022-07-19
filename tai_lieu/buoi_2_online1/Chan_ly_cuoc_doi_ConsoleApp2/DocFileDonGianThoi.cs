using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class DocFileDonGianThoi
    {
        static void Main1(string[] args)
        {
            //Dòng này dùng để đọc Tiếng Việt cô sử dụng .UTF8 thay cho Unicode nhưng mình thấy Unicode bao trùm hay sao á
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Dòng này dùng để ghi Tiếng Việt
            Console.InputEncoding = System.Text.Encoding.Unicode;


            string filename = "file1.txt";
            ReadFileText(filename);//hai cái này chỉ là hàm/phương thức mình viết thôi
            WriteFileText();//hai cái này chỉ là hàm/phương thức mình viết thôi
            Console.ReadLine();
        }
        static void ReadFileText(string filename)
        {
            if (File.Exists(filename))//Kiểm tra xem cái file truyền  đấy nó có tồn tại hay không
            {
                
                //có hai cách cách này dùng để ghi rõ ra từng dòng mọt hiện cho mình thôi 
                //string[] lines;
                //lines = File.ReadAllLines(filename);
                //for (int i = 0; i < lines.Length; i++)
                //{
                //    Console.WriteLine("Line " + i + " : " + lines[i]);
                //}


                //cách này là đọc toàn bộ thôi
                string str;
                str = File.ReadAllText(filename);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Không có file " + filename);
            }

        }
        static void WriteFileText()
        { 

            //CÁCH 1
            string file1 = @"file2.txt";
            string[] lines = new string[2];
            //lines[0] = "Covid 19 has outbreak in the world";//đây là cô viết trực tiếp vào
            //lines[1] = "Everyone should be at home";
            for (int i = 0; i < lines.Count(); i++)//đây là kiểu nhập từ bàn phím
            {
                Console.Write("Dòng "+(i+1)+" : ");
                lines[i] = Console.ReadLine();
            }
            File.WriteAllLines(file1, lines);


             // CÁCH 2
            string file2 = @"file3.txt";
            //string str = "Cộng hòa xã hội chủ nghĩa Việt nam";//đây là ghi trực tiếp
            Console.WriteLine("Ghi vào file: ");//nhập vào từ bàn phím
            string str = Console.ReadLine();
            File.WriteAllText(file2, str);
        }
    }
}
