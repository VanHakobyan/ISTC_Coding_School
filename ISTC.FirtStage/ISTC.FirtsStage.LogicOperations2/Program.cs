using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperations2
{
    class Program
    {
        static void Main(string[] args)
        {



            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string str4 = Console.ReadLine();

            int number1 = int.Parse(str1);
            int number2 = int.Parse(str2);
            int number3 = int.Parse(str3);
            bool flag = bool.Parse(str4);

            bool b1 = number3 > 2;
            bool b2 = number1 > 5;

            bool b = !b1 && !b2;
            bool bb = !(b1 || b2);



            bool ex1 = number1 > 0 && number2 != number3;// true,false =>false

            bool ex2 = number2 < short.MinValue && number3 > byte.MaxValue;


            if (ex1 || ex2 && flag)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadKey();
        }
    }
}
