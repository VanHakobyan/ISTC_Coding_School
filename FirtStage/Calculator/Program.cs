using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input operation");
            string operation = Console.ReadLine();

            Console.WriteLine("Please input number1 = ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input number2 = ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool flag = true;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 + number2;
                    break;
                case "*":
                    result = number1 + number2;
                    break;
                case "/":
                    result = number1 + number2;
                    break;
                default:
                    flag = false;
                    break;
            }

            string resultString = $"{number1} {operation} {number2} = {result}";

            Console.WriteLine(flag ? resultString : "Wrong operation");





            //if (operation == "+")
            //    Console.WriteLine(Math.Abs(number1 + number2));
            //else if (operation == "-")
            //    Console.WriteLine(Math.Abs(number1 - number2));
            //else if (operation == "*")
            //    Console.WriteLine(Math.Abs(number1 * number2));
            //else if (operation == "/")
            //    Console.WriteLine(Math.Abs(number1 / number2));
            //else
            //    Console.WriteLine("error");
        }
    }
}
