using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTC.ThirdStage.Advance.Algorithms.Sorting.Sorting;

namespace ISTC.ThirdStage.Advance.Algorithms.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 135, 864, 1368, 4134, 6, 9, 1 };
            Merge.Mergesort(array);
            Console.WriteLine(string.Join(",", array.ToList()));
        }


        private static List<int> MyMethod()
        {
            var list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {

                int N = new Random().Next(0, int.MaxValue);
                list.Add(N);
            }

            return list;
        }//O(N^2)
    }
}
