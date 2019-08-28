using System;
using System.Threading;

namespace ISTC.ThirdStage.Advance.AMM.AMM01
{
    class Program
    {
        public static A RefA;
        public static B RefB;

        static void Main()
        {
            RefB = new B();
            RefA = new A();
            RefB.Ref = RefA;

            RefB = null;
            RefA = null;

            // A and B now eligible for destruction
            GC.Collect();
            //GC.WaitForPendingFinalizers();
            //Thread.Sleep(5000);
            // B now eligible for collection, but A is not
            if (RefA != null)
                Console.WriteLine("RefA is not null");
        }
    }
}
