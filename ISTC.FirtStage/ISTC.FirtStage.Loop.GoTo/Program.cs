using System;

namespace ISTC.FirtStage.Loop.GoTo
{
    class Program
    {
        static void Main()
        {
            int number = 123456;
            int sum = 0;

        L:
            int digit = number % 10;//get last digit //23658585
            sum += digit;
            number = number / 10;   //cut last digit 

            if (number < int.MaxValue)
            {
                goto L;
            }

            sum += number;

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
