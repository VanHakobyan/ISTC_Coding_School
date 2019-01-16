using System;
using System.Diagnostics;
using System.Threading;

namespace ISTC.ThirdStage.Advance.Parallel.Pl_01
{
    class Program
    {
        static void Main()
        {
            string[] colors = {
                "1. Red",
                "2. Green",
                "3. Blue",
                "4. Yellow",
                "5. White",
                "6. Black",
                "7. Violet",
                "8. Brown",
                "9. Orange",
                "10. Pink"
            };
            Console.WriteLine("Traditional foreach loop");
            //start the stopwatch for "for" loop
            var sw = Stopwatch.StartNew();
            foreach (string color in colors)
            {
                Console.WriteLine("{0}, Thread Id= {1}", color, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            Console.WriteLine("foreach loop execution time = {0} seconds\n", sw.Elapsed.TotalSeconds);
            Console.WriteLine("Using Parallel.ForEach");
            //start the stopwatch for "Parallel.ForEach"
            sw = Stopwatch.StartNew();
            System.Threading.Tasks.Parallel.ForEach(colors, color =>
                {
                    Console.WriteLine("{0}, Thread Id= {1}", color, Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(10);
                }
            );
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", sw.Elapsed.TotalSeconds);
            Console.ReadKey();
        }
    }
}
