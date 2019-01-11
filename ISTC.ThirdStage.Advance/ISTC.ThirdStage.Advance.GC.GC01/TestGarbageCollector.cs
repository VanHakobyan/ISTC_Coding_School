using System;
using System.Linq;
using System.Threading;

namespace ISTC.ThirdStage.Advance.GC.GC01
{
    public class TestGarbageCollector
    {
        private long[] array = new long[1024 * 1024 * 5];

        public string GetArrayInfo()
        {
            return string.Join(",", array.Select(x => x.GetHashCode()));
        }
        ~TestGarbageCollector()
        {
            Console.WriteLine($"Object removed code is {GetHashCode()}");
            Thread.Sleep(100);
        }
    }
}
