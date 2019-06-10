using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;
            char sim = 'a';
            string s = "name";
            float k = 15.12f;
            double d = 123;



            int n1 = 5;
            n1 = n1 + 2;//(1)

            n1 *= 2;//(2)
            n1 -= 2;//(2)
            n1 *= 2;//(2)
            n1 /= 2;//(2)
            Console.WriteLine(n1);//7
        }
    }
}
