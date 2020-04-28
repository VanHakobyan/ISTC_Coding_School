using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.LogicalStatements_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolText = Console.ReadLine();
            int number = Convert.ToInt32(boolText);


            if (number == 1)
            {
                Console.WriteLine("number=1");
            }
            else if (number == 2)
            {
                Console.WriteLine("number=2");
            }
            else if (number == 3)
            {
                Console.WriteLine("number=3");
            }
            else if (number == 4)
            {
                Console.WriteLine("number=4");
            }
            else if (number == 5)
            {
                Console.WriteLine("number=5");
            }
            else if (number == 6)
            {
                Console.WriteLine("number=6");
            }
            else if (number == 7)
            {
                Console.WriteLine("number=7");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("number=1");
                    break;
                case 2:
                    Console.WriteLine("number=2");
                    break;
                case 3:
                    Console.WriteLine("number=3");
                    break;
                case 4:
                    Console.WriteLine("number=4");
                    break;
                case 5:
                    Console.WriteLine("number=5");
                    break;
                case 6:
                    Console.WriteLine("number=6");
                    break;
                case 7:
                    Console.WriteLine("number=7");
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }
    }
}
