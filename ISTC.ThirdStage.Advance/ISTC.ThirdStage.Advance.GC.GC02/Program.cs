using System;

namespace ISTC.ThirdStage.Advance.GC.GC02
{
    class Program
    {
        #region NOTE
        //So when should you call the GC.Collect method in your .NET programs?
        //You should never call it !!!
        //The call will usually not do much to reduce overall memory usage.
        //And it will impose a slowdown whenever it is called. 
        #endregion

        static void Main(string[] args)
        {
            long mem1 = System.GC.GetTotalMemory(false);


            // Allocate an array and make it unreachable.
            int[] values = new int[50000];
            values = null;

            long mem2 = System.GC.GetTotalMemory(false);

            // Collect garbage.
            System.GC.Collect();

            long mem3 = System.GC.GetTotalMemory(false);

            Console.WriteLine(mem1);
            Console.WriteLine(mem2);
            Console.WriteLine(mem3);

            Console.ReadKey();
        }
    }
}
