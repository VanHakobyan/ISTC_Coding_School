using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.TPL.TPL03
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";
         
            // Create a task and supply a user delegate by using a lambda expression. 
            Task taskA = new Task(Write);
            // Start the task.
            taskA.Start();
          
            // Output a message from the calling thread.
            Console.WriteLine($"Hello from thread '{Thread.CurrentThread.ManagedThreadId}'.");
            Console.WriteLine($"Pool '{Thread.CurrentThread.IsThreadPoolThread}'.");
            taskA.Wait();
            
            Console.ReadLine();

        }

        public static void Write()
        {
            Thread.Sleep(5000);
            var currentThreadManagedThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Hello from taskA. "+currentThreadManagedThreadId);
        }
    }
}
