using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1; y = 2;
            int z = x++ - ++y + 1;

            Console.WriteLine("Gia tri cua z = " + z);
            Console.ReadKey();
        }
    }
}
