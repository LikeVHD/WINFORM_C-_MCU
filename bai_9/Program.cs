using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luachon;
            Console.WriteLine("CHUONG TRINH TIM KIEM");
            Console.WriteLine("1. Tim theo ten");
            Console.WriteLine("2. Tim theo tac gia");
            Console.WriteLine("3. Tim theo NXB");
            Console.WriteLine("4. Tim theo tieu de");
            Console.WriteLine("Moi bam cac phim 1 - 2 - 3 - 4 tuong ung de lua chon!");
                        luachon = int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    Console.WriteLine("Tim theo ten");
                    break;
                case 2:
                    Console.WriteLine("Tim theo tac gia");
                    break;
                case 3:
                    Console.WriteLine("Tim theo NXB");
                    break;
                case 4:
                    Console.WriteLine("Tim theo tieu de");
                    break;
                default:
                    Console.WriteLine("Phim bam khong hop le!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
