using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number >= 0)
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("all ok");
            }
            Console.WriteLine("bad !!!");
            Console.ReadKey();
        }
    }
}
