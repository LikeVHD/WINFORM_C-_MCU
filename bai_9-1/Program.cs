using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Moi nhap vao bien n");
            //Console.ReadKey();
            n = int.Parse(Console.ReadLine());
            while (n<1 || n>99)
            {
                Console.WriteLine("Nhap lai bien n, n chi duoc nam trong khoang tu 1 den 99!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ban da nhap vao n = " +n);
            Console.ReadKey();
         }
    }
}
