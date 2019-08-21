using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.GC.GC05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            for (int i = 0; i < 1000000; i++)
            {
                list1.Add($"{i}");
            }

            var totalMemory1 = System.GC.GetTotalMemory(false);

            List<string> list2 = new List<string>();
            for (int i = 0; i < 1000000; i++)
            {
                list2.Add($"{i*-1}" + $"{int.MaxValue-i}");
            }

            var totalMemory2 = System.GC.GetTotalMemory(false);
            var total = totalMemory2 - totalMemory1;
        }
    }
}
