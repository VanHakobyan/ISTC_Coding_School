using System;

namespace ISTC.FirtStage.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var readLine = Console.ReadLine();
                int n = int.Parse(readLine);
                ulong factorial = 1;
                for (uint i = 2; i < n + 1; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
            //factorial=1
            //1. factorial = 2
            //2. factorial=6
            //3. 24
            //4. 120
            //5. 720
           
        }
    }
}
