using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            bool tryParse = TryParse(n, out int result);
            result = 10;
            Console.WriteLine(result);
            Console.ReadKey();
        }


        //int-return type
        //Sum-name
        //n1,n2 - params
        static int Sum(int n1, int n2)
        {
            int sum = n1 + n2;
            n1 = 45;
            return sum;
        }

        static void Print(int sum)
        {
            Console.WriteLine("N1+N2=" + sum);
        }
        static void Print(int sum, string text)
        {
            Console.WriteLine(text + sum);
        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static int SumAllDigits()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }

            return sum;
        }

        //Գտնել տրված բնական թվից մեծ և 2-ի աստիճան հանդիսացող ամենափոքր թիվը։


        /// <summary>
        /// get max number
        /// </summary>
        /// <param name="number">natural number</param>
        /// <returns></returns>
        static int GetNumber(int number)
        {
            for (int i = 2; i < int.MaxValue; i *= 2)
            {
                if (number < i)
                {
                    return i;
                }
            }
            return -1;
        }


        static void PrintName(string fName, string lName, string title = "student")
        {
            Console.WriteLine("I'm " + title + " my name is " + fName + " " + lName);
        }

        static int GetSum(ref int n1, ref int n2)
        {
            int sum = n1 + n2;
            n1 = 0;
            n2 = -1;
            return sum;
        }

        static void GetNumberSum(int n1, int n2, out int result)
        {
            result = n1 + n2;
        }

        static bool TryParse(string s, out int result)
        {
            try
            {
                result = int.Parse(s);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }
}
