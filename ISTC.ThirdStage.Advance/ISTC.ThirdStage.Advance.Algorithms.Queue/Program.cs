using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Algorithms.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueCustom<int> queue=new QueueCustom<int>();

            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(5);
            var dequeue = queue.Dequeue();
            Console.WriteLine(dequeue);

            Console.ReadKey();
        }
    }
}
