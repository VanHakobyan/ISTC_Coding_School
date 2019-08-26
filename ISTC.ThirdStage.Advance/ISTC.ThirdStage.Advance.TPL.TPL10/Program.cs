using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.TPL.TPL10
{
    public class TaskBuilding
    {
        public double Square(double arg)
        {
            return arg * arg;
        }

        public void BuidTasks(Task[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = Task.Factory.StartNew
                (
                    () =>
                    {
                        Console.WriteLine($"i1 Square {i} = {Square(i)} - ThreadId = {Thread.CurrentThread.ManagedThreadId}");
                        Thread.Sleep(5000);
                        
                    }
                );
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task[] array = new Task[3];
            TaskBuilding task = new TaskBuilding();
            task.BuidTasks(array);
            Console.ReadKey();
        }
    }
}
