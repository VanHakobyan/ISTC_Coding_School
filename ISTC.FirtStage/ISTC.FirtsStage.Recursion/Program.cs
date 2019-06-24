using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Recursion
{
    class Program
    {
        static void Writer(int number)
        {
            if (number > 0)
            {
                Writer(number - 1);
                Console.WriteLine(number);
                Writer(number - 1);
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static long Fib(long index)
        {
            if (index <= 1) return 1;
            return Fib(index - 1) + Fib(index - 2);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopwatchR = new Stopwatch();
                stopwatchR.Start();
                long sumOfDigits = SumOfDigitsRec(1121655755766561353);
                stopwatchR.Stop();


                Stopwatch stopwatchI = new Stopwatch();
                stopwatchI.Start();
                long sumOfDigits2 = SumOfDigits(1121655755766561353);
                stopwatchI.Stop();

                Console.WriteLine($"Rec={stopwatchR.Elapsed.TotalMilliseconds} \nIter={stopwatchI.Elapsed.TotalMilliseconds}");
                Console.WriteLine(sumOfDigits);
                Thread.Sleep(1000);
            }

            Console.ReadKey();

            RecursiveMethod(11400);
            Console.WriteLine("end");
            //long factorial = Factorial(28);
            //Console.WriteLine(factorial);
            //long fib = Fib(8);
            //Console.WriteLine(fib);
            //Writer(3);
        }

        //5
        static long Factorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            long temp = number * Factorial(number - 1);//Factorial(4);
            return temp;
        }

        static bool RecursiveMethod(int x)
        {
            if (x != 0) RecursiveMethod(--x);
            return true;
        }

        static long SumOfDigitsRec(long number)
        {
            if (number / 10 == 0) return number;//բազիս
            return number % 10 + SumOfDigitsRec(number / 10);
        }

        static long SumOfDigits(long number)
        {
            long sum = 0;
            while (number / 10 > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
