using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Console.WriteLine("Learn programming");  
            //} while (true);

            Console.ReadKey();
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                if (number % 10 == 9)
                {
                    number /= 10;
                    continue;
                }

                sum += number % 10;
                number /= 10;

                //if (number % 10 == 1) break;
            }


            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
