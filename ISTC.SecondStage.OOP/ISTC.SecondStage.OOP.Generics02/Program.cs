using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Generics02
{
    class Program
    {
        static void Swap<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            char c = 'c';
            char d = 'd';


            Swap(ref d, ref c);
            Swap(ref a, ref b);


            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            Console.WriteLine($"b={c}");
            Console.WriteLine($"d={d}");
        }
    }
}
