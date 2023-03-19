using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace slide18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            Console.WriteLine(currDir.FullName);

            DirectoryInfo duongdan = new DirectoryInfo(@"D:\Soft\PLC Xinje"); //Khai báo nguyên văn dùng dấu @
            Console.WriteLine(duongdan.FullName);
            //lấy tên thư mục
            Console.WriteLine(duongdan.Name);
            //get thư mục cha
            Console.WriteLine(duongdan.Parent);
            //get thuộc tính
            Console.WriteLine(duongdan.Attributes);
            //kiểm tra thời gian tạo thư mục
            Console.WriteLine(duongdan.CreationTime);

            //3. Tạo thư mục cách 1
            //DirectoryInfo thumuc1 = new DirectoryInfo(@"D:\tuhoc.cc");
            //thumuc1.Create();
            //cách 2
            //string thumuc2 = @"D:\tuhoc2.cc";
            //Directory.CreateDirectory(thumuc2);

            //4
            string path1 = @"D:\tuhoc2.cc";
            if (Directory.Exists(path1))
            {
                Console.WriteLine("Thư mục đã tồn tại rồi Sếp ơi!");
            }
            else
            {
                Console.WriteLine("Thư mục chưa có");
            }

            //5 Xoá thư mục
            //string path2 = @"D:\tuhoc2.cc";
            //Directory.Delete(path2);

            //6 get file path
            string path3 = @"D:\Soft\PLC Xinje";
            string[] danhsach = Directory.GetFiles(path3);
            Console.WriteLine($"Danh sách file nằm trong thư mục {path3} là: ");
            foreach (string file in danhsach)
            {
                Console.WriteLine(file);
            }

            //7 get directory
            string path4 = @"D:\";
            string[] danhsachthumuc = Directory.GetDirectories(path4);
            Console.WriteLine($"Danh sách thu mục nằm trong ổ D {path4} là: ");
            foreach (string dir in danhsachthumuc)
            {
                Console.WriteLine(dir);
            }


            Console.ReadKey();
        }
    }
}
