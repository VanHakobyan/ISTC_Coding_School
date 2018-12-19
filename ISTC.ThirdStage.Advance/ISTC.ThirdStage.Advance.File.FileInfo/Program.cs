using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.File.FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo("C:\\Windows");
            System.IO.FileInfo[] filesInDir = dirinfo.GetFiles();
            foreach (System.IO.FileInfo file in filesInDir)
            {
                Console.WriteLine($"File Name {file.FullName} Size: {file.Length} bytes");
            }
            Console.Read();
        }
    }
}
