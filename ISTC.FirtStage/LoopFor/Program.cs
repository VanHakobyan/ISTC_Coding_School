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
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count*count; i+=2)
            {
                Console.WriteLine($"i={i}");
                Console.WriteLine($"i*i={i * i}");
                if(i==4) break;
            }

            Console.ReadKey();
        }
    }
}
