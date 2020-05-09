using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.Rec_02
{
    class Program
    {
        static void Sum(int a, int b)
        {
            var res = a + b;
            Console.WriteLine(res);
            a--;
            b--;
            if (!(a == 0 || b == 0)) Sum(a, b);
        }
        static void Main(string[] args)
        {
            Sum(5, 9);
        }
    }
}
