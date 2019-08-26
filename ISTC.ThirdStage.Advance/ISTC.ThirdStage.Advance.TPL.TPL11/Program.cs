using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.TPL.TPL11
{
    class Program
    {
        private static readonly int[] List = new int[100];
        private static int i = 0;
        private static int y = 0;
        public static void Method()
        { 
            List[i] = (i++);
        }
        public static void Method2()
        {
            List[y] = (y++);
        }
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            for (int j = 0; j < 50; j++)
            {
                var t = new Task(Method);
                tasks.Add(t);
            }

            List<Task> tasks2 = new List<Task>();
            for (int j = 0; j < 50; j++)
            {
                var t = new Task(Method2);
                tasks2.Add(t);
            }

            Task.Factory.StartNew(() => tasks.ForEach(task => task.Start()));
            Task.Factory.StartNew(() => tasks2.ForEach(task => task.Start()));
            Task.WaitAll(tasks.ToArray());
            Task.WaitAll(tasks2.ToArray());
            Console.ReadKey();
        }
    }
}
