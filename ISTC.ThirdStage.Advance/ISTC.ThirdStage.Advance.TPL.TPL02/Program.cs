using System;
using System.Threading;

namespace ISTC.ThirdStage.Advance.TPL.TPL02
{
    //async
    class Program
    {
        static void Main(string[] args)
        {
            Action handler = new Action(Display);

            IAsyncResult resultObj = handler.BeginInvoke(null, null);
            Console.WriteLine("Continue: Main");
            handler.EndInvoke(resultObj);
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