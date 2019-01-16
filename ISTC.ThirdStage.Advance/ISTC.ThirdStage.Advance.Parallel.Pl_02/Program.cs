using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Parallel.Pl_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using For Loop \n");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }

            Console.WriteLine("\nUsing Parallel.For \n");

            System.Threading.Tasks.Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });

            Console.ReadLine();
        }
    }
}
