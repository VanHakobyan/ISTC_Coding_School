using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ISTC.ThirdStage.Advance.GC.GC01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestGarbageCollector> testGarbageCollectors = new List<TestGarbageCollector>();
            int i = 0;
            for (; ; i++)
            {
                try
                {
                    testGarbageCollectors.Add(new TestGarbageCollector());
                    Thread.Sleep(50);
                }
                catch (OutOfMemoryException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine($"Created {i} items");
                    Console.WriteLine(new string('-', 50));
                    //Console.WriteLine(string.Join("\n", testGarbageCollectors.Select(x => x.GetHashCode())));
                    for (int j = 0; j < testGarbageCollectors.Count - 1; j++)
                    {
                        testGarbageCollectors[j] = null;
                    }
                    System.GC.Collect();
                    continue;
                    //break;
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
