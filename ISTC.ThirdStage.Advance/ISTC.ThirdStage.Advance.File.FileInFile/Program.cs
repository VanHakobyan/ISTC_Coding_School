using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.File.FileInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.AppendAllLines(@"C:\Users\vanik.hakobyan\source\Text.txt", Enumerable.Range(0, 100).Select(x => x.ToString()));
        }
    }
}
