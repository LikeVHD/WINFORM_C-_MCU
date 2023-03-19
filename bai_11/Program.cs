using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lst = {1, 3, 5, 7, 9};        // khoi tao 1 list
            foreach (int i in lst)
            {
                Console.WriteLine("i = " + i);
            }
            Console.ReadKey();
        }
    }
}
