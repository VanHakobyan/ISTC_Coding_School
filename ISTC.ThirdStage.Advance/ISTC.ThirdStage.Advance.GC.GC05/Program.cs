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
                list1.Add($"456");
            }

            var totalMemory1 = System.GC.GetTotalMemory(false);

            List<string> list2 = new List<string>();
            for (int i = 0; i < 1000000; i++)
            {
                list2.Add($"456789");
            }

            var totalMemory2 = System.GC.GetTotalMemory(false) - totalMemory1;
        }
    }
}
