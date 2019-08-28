using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 2; sum < 1000; i += 2)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();



            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count * count; i += 2)
            {
                Console.WriteLine($"i={i}");
                Console.WriteLine($"i*i={i * i}");
                if (i == 4) break;
            }

            Console.ReadKey();
        }
    }
}
