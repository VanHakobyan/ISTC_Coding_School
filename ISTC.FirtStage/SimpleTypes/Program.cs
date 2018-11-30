using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool flag;
            //flag = true;
            ////Console.WriteLine(flag);
            //string readLine = Console.ReadLine();
            //flag = Convert.ToBoolean(int.Parse(readLine));

            //if (flag)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            byte b = 0;
            byte y = 5;
            ++b;
            b += 5;
            Console.WriteLine(b);

            short sh = 5;
            short sh2 = 50;

            int number = 587;
            int number2 = 158;
            int resInt = number2 + number;


            long lNumber = 16000;
            long lNumber2 = long.MaxValue - 15000;
            long reslong = lNumber2 + lNumber;


            float f1 = 1.55645614564156456456f;
            float f2 = 1.8f;
            float fRes = f1 + f2;
            float fResMax = float.MaxValue - f2;


            double d1 = 64654.5;
            double d2 = 64654.5;

            double dRes = d1 + d2;

            decimal dec1 = 564564.345m;
            decimal dec2 = decimal.MinValue;

            decimal decRes = dec1 + dec2;
            
        }
    }
}
