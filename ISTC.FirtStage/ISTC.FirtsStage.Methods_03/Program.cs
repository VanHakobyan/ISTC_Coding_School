using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirtsStage.Methods_03
{
    class Program
    {
        static int[] GenerateDigits(int number)
        {
            int numberLength = (int)Math.Ceiling(Math.Log10(number));

            int[] array = new int[numberLength];

            int index = 0;
            while (number != 0)
            {
                int digit = number % 10;
                array[index] = digit;
                index++;
                number /= 10;
            }

            return array;
        }

        static int GetNumber()
        {
            string str = Console.ReadLine();
            int number = int.Parse(str);

            return number;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }
        }

        static void Delay()
        {
            Console.ReadKey();
        }

        static int SumDigits(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            return sum;
        }

        static double ArithmeticMean(int[] array)
        {
            int sumDigits = SumDigits(array);
            double ar = sumDigits / (double)array.Length;

            return ar;
        }

        static double ArithmeticMeanV2(int[] array)
        {
            return SumDigits(array) / (double)array.Length;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, short b)
        {
            return a + b ;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }

        static void WriteNumber(int x = 100)
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            WriteNumber();

            int number = GetNumber();
            int[] array = GenerateDigits(number);

            int sumDigits = SumDigits(array);
            double arithmeticMean = ArithmeticMean(array);

            PrintArray(array);

            Delay();
        }
    }
}
