using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            int gt = 1; 
            Console.WriteLine("Nhap vao so nguyen duong n");
            n = int.Parse(Console.ReadLine());
            // Tinh n giai thua
            while (i <= n)
            {
                gt *= i;
                i++;
            }
            Console.WriteLine("Gia thua cua {0} bang {1}",  n, gt);
            Console.ReadKey();
        }
    }
}
