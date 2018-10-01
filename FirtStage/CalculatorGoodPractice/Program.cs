using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGoodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input operation ");
            string operation = Console.ReadLine();

            Console.Write("Please input number1 = ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Please input number2 = ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool flag = true;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    flag = false;
                    break;
            }

            Console.WriteLine(flag ? $"{number1}  {operation} {number2} = {result}" : "Wrong operation");
        }
    }
}
