using System;
using System.IO;

namespace ISTC.ThirdStage.Advance.HomeWork.HW03
{
    class Program
    {
        private static void TraverseDir(DirectoryInfo direction, string spaces)
        {
            Console.WriteLine(spaces + direction.FullName);

            DirectoryInfo[] files = direction.GetDirectories();

            foreach (DirectoryInfo file in files)
            {
                FileInfo[] fileInfo = file.GetFiles();
                Console.WriteLine("Files");
                foreach (FileInfo item in fileInfo)
                {
                    Console.WriteLine(item.Name);
                }
                TraverseDir(file, spaces + "-");
            }

        }

        public static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath), "%");
        }

        public static void Main()
        {
            string path;
            do
            {
                Console.Write("Path Name:");
                path = Console.ReadLine();
            }
            while (!Directory.Exists($@"D:\{path}"));

            TraverseDir($@"D:\{path}");

            Console.ReadKey();
        }
    }
}
