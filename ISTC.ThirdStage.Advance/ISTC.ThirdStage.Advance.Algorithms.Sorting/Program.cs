using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Algorithms.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
        }

        private static void MyMethod()
        {
            int N = new Random().Next(0, int.MaxValue);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine(j);
                }//O(N)
                Console.WriteLine(i); //O(1)
                string x = $"554";
            }//O(N)

        }//O(N^2)
    }
}
