using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirtStage.ConditionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch-Case
            //DayOfWeek

            while (true)
            {
                string text = Console.ReadLine();
                int week = int.Parse(text);

                if (week > 31)
                {
                    Console.WriteLine("Wrong day of month");
                    week = int.MinValue;
                }

                if (week > 6)
                {
                    week = week % 7;
                }

                switch (week)
                {
                    case 0:
                        Console.WriteLine(DayOfWeek.Monday);
                        break;
                    case 1:
                        Console.WriteLine(DayOfWeek.Tuesday);
                        break;
                    case 2:
                        Console.WriteLine(DayOfWeek.Wednesday);
                        break;
                    case 3:
                        Console.WriteLine(DayOfWeek.Thursday);
                        break;
                    case 4:
                        Console.WriteLine(DayOfWeek.Friday);
                        break;
                    case 5:
                        Console.WriteLine(DayOfWeek.Saturday);
                        break;
                    case 6:
                        Console.WriteLine(DayOfWeek.Sunday);
                        break;
                    default:
                        Console.WriteLine("Wrong number day of week");
                        break;
                }

            }


            Console.ReadKey();

            //Ternary

            //string text = Console.ReadLine();
            //int number = int.Parse(text);//45
            ////string s = number > 4 ? ">" : "<";
            //int firstNumber = number / 10;//4
            //int secondNumber = number % 10;//5

            //int doubleMul = 2 * firstNumber * secondNumber;
            //if (doubleMul > number)
            //{
            //    Console.WriteLine(doubleMul + ">" + number);
            //}
            //else if (doubleMul < number)
            //{
            //    Console.WriteLine(doubleMul + "<" + number);
            //}
            //else
            //{
            //    Console.WriteLine(doubleMul + "==" + number);
            //}



            //If-else

            //bad practice 

            //if (number > 0)
            //{
            //    Console.WriteLine("Number>0");
            //}
            //else
            //{
            //    if (number == 0)
            //    {
            //        Console.WriteLine("number==0");
            //    }
            //    else
            //    {
            //        Console.WriteLine("number<0");
            //    }
            //}

            //good practice 
            //if (number > 0)
            //{
            //    Console.WriteLine("Number>0");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("number<0");
            //}
            //else
            //{
            //    Console.WriteLine("number==0");
            //}
        }
    }
}
