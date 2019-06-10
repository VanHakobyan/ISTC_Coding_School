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
            byte b = 255;
            b += 5;
            Console.WriteLine(b);

            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;

            byte y = 5;
            ++b;
            Console.WriteLine(b);//b=1
            int result = b + 1;//result=2 

            b += 5;


            Console.WriteLine(b);//

            short sh = 5;
            short sh2 = 50;
            int r = sh2 / sh;
            
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

            decimal dec1 = 564564.34654646468468468465m;
            decimal dec2 = decimal.MinValue;

            decimal decRes = dec1 + dec2;

        }
    }
}
