using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Algorithms.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackCustom<int> stack = new StackCustom<int>(100);
            var random = new Random();

            stack.Push(int.MaxValue);

            for (int i = 0; i < 150; i++)
            {
                stack.Push(random.Next(10, 100));
            }

            Console.WriteLine("Press any key to pop all items");
            Console.ReadKey();
            for (int i = 0; i < 150; i++)
            {
                var item = stack.Pop();
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
