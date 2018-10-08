using System;

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
                Console.WriteLine("input");
            }
            Console.WriteLine("bad !!!");
            Console.ReadKey();
        }
    }
}
