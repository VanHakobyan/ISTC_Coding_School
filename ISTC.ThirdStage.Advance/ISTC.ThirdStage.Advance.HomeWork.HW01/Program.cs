using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.HomeWork.HW01
{
    public class AllDirectories
    {
        public static void PrintFiles(string path)
        {
            Thread.Sleep(4);
            string[] files = Directory.GetFiles(path);
            var paths = Directory.GetDirectories(path).Where(d => !d.EndsWith("Settings") &&
                                                                  !d.EndsWith("Bin") 
                                                                  &&!d.EndsWith("Cache") 
                                                                  && !d.EndsWith("Information"));
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            foreach (string dir in paths)
            {
                Console.WriteLine("Directory:");
                Console.WriteLine(dir);
                Console.WriteLine("Files of the directory:");
                Thread.Sleep(4);
                PrintFiles(dir);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                Console.WriteLine(drive);
            }

            string generalDrive = Console.ReadLine().ToUpper() + ":\\";

            if (drives.Contains(generalDrive))
            {
                AllDirectories.PrintFiles(generalDrive);
            }
            else
            {
                Console.WriteLine("Please enter a valid directory name!");
            }
            Console.ReadKey();
        }
    }
}
