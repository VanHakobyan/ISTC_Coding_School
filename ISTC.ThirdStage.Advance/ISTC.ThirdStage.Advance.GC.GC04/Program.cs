using System;

namespace ISTC.ThirdStage.Advance.GC.GC04
{
    class Program
    {
        static void Main()
        {
            long bytes1 = System.GC.GetTotalMemory(false); // Get memory in bytes

            byte[] memory = new byte[1000 * 1000 * 10]; // Ten million bytes
            memory[0] = 1; // Set memory (prevent allocation from being optimized out)

            long bytes2 = System.GC.GetTotalMemory(false); // Get memory
            long bytes3 = System.GC.GetTotalMemory(true); // Get memory

            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1); // Write difference
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2); // Write difference
            Console.ReadLine();
        }
    }
}
