using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.Name);
            Console.WriteLine(thread.GetHashCode());
            Process.Start("https://www.facebook.com/");


        }
    }
}
