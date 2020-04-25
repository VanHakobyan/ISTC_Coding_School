using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirtStage.BitOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 & 4);
            Console.WriteLine(3 | 4);
            Console.WriteLine(3 ^ 4);
            Console.WriteLine(~4);
            Console.WriteLine(4 >> 2);
            Console.WriteLine(4 << 2);
        }
    }
}
