using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.File.Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Environment.MachineName;
            var userName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\\Windows");
            Console.WriteLine($"Full Name of the directory is : {dirinfo.FullName}");
            Console.WriteLine($"The directory was last accesses on: { dirinfo.LastAccessTime}");
            Console.ReadKey();
        }
    }
}
