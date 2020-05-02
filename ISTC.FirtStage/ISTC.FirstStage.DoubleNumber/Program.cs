using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.DoubleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = -200; number <= 10000; number++)
            {
                int compareNumber = number;
                int sum = 0;

                while (compareNumber != 0)
                {
                    sum += compareNumber % 10;
                    compareNumber /= 10;
                }

                if (sum * 2 == number) Console.WriteLine($"yes {number}");
                //else Console.WriteLine($"no {number}");
            }

            Console.ReadKey();
        }
    }
}
