using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            do
            {
                Console.WriteLine("\nEnter number");

                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(n1 + n2);
                Console.WriteLine("\nFor exit select esc!!!\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
