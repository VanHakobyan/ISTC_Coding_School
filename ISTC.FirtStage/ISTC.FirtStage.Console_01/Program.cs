using System;

namespace ISTC.FirtStage.Console_01
{
    class Program
    {
        //My first main method
        static void Main()
        {
            string text = Console.ReadLine();//read
            int number = Convert.ToInt32(text);//13
            int lastDigit = number % 10;
            int firstDigit = number / 10;

            int sum = lastDigit + firstDigit;
            Console.WriteLine($"Sum={sum}");
            Console.ReadKey();
        }
    }
}
