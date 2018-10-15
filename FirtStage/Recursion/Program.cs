using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Writer(int number)
        {
            if (number > 0)
            {
                Writer(number-1);
                Console.WriteLine(number);
                Writer(number-1);
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static long Fib(long index)
        {
            if (index <= 1) return 1;
            return Fib(index - 1) + Fib(index - 2);
        }
        static void Main(string[] args)
        {
            long fib = Fib(50);
            Console.WriteLine(fib);
            Console.ReadKey();
            //Writer(3);
        }
    }
}
