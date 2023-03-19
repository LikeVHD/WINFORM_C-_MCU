using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float diemTotNghiep;
            Console.WriteLine("Moi nhap vao diem tot nghiep:");
            diemTotNghiep = float.Parse(Console.ReadLine());
            
            //check dieu kien
            if (diemTotNghiep > 7)
                Console.WriteLine("Ban da do!");
            else
                Console.WriteLine("Diem tot nghiep cua ban la {0}, Ban da tach!", diemTotNghiep);
            Console.ReadKey();

        }
    }
}
