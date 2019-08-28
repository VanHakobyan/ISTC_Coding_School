using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection.Yield
{
    class Program
    {
        public static void Consumer()
        {
         
            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static IEnumerable<int> Integers()
        {
            //return new[] {1, 2, 4, 8, 16, 5641651};
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
            
        }
        static void Main(string[] args)
        {
            Consumer();
        }
    }
}
