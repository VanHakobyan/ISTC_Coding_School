using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorGoodPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.CursorVisible = false;
            //Console.SetCursorPosition(25,35);
            //Console.WriteLine(Console.CapsLock.ToString());

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            Console.WriteLine(consoleKeyInfo.Key.ToString());
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please input operation ");
            Console.ForegroundColor = ConsoleColor.Red;
            string operation = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please input number1 = ");
            Console.ForegroundColor = ConsoleColor.Red;
            double number1 = double.Parse(Console.ReadLine());

            //Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please input number2 = ");
            Console.ForegroundColor = ConsoleColor.Red;
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(flag ? $"{number1}  {operation} {number2} = {result}" : "Wrong operation");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ReadKey();
        }
    }
}
