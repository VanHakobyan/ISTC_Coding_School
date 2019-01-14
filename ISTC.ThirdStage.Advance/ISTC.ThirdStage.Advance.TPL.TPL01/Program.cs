using System;
using System.Threading;


namespace ISTC.ThirdStage.Advance.TPL.TPL01
{
    //Block 
    class Program
    {
        static void Main(string[] args)
        {
            Action handler = new Action(Display);
            handler.Invoke();

            Console.WriteLine("Continue: Main");
            
            Console.ReadLine();
        }

        static void Display()
        {
            Console.WriteLine("Start: Display....");

            int result = 0;
            for (int i = 1; i < 10; i++)
            {
                result += i * i;
            }
            Thread.Sleep(3000);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Stop: Display....");
        }
    }
}

