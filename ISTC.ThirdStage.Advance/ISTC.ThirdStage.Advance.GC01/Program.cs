using System;
using System.Collections.Generic;
using System.Linq;

namespace ISTC.ThirdStage.Advance.GC.GC01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestGarbageCollector>  testGarbageCollectors=new List<TestGarbageCollector>();
            int i = 0;
            for(;;i++)
            {
                try
                {
                    testGarbageCollectors.Add(new TestGarbageCollector());
                }
                catch (OutOfMemoryException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(new string('-',50));
                    Console.WriteLine($"Created {i} items");
                    Console.WriteLine(new string('-',50));
                    Console.WriteLine(string.Join("\n", testGarbageCollectors.Select(x => x.GetHashCode())));
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
