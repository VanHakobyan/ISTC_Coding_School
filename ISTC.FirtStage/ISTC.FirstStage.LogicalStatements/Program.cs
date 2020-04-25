using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.LogicalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string aText = Console.ReadLine();
            int a = Convert.ToInt32(aText);

            string bText = Console.ReadLine();
            int b = Convert.ToInt32(bText);

            string cText = Console.ReadLine();
            int c = Convert.ToInt32(cText);

            bool result = (a < 6) && ((b <= 2) || (c >= 1));

            Console.WriteLine($"Result is {result}");
            // &, |, ^, ~, >>, <<,!

            //&&, ||, !, >, <, <= , >=, ==,!= //bool

            bool x = false || true;
            bool y = false && true;
            bool z = !true;

            bool r1 = 5 > 6;
            bool r2 = 5 < 6;
            bool r3 = 5 <= 6;
            bool r4 = 5 >= 6;
            bool r5 = 5 == 6;
            bool r6 = 5 != 6;

            if ((a < 6) && ((b <= 2) || (c >= 1)))
            {
                Console.WriteLine("Ճիշտա");
            }
            else
            {
                Console.WriteLine("Սխալա");
            }

            Console.ReadKey();
        }
    }
}
