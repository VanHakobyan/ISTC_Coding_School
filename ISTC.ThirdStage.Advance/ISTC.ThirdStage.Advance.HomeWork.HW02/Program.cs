using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.HomeWork.HW02
{
    class Program
    {
        static int folderCount = 0;
        static int fileCount = 0;

        static void PrintFolders(DirectoryInfo directory, int pos = 0)
        {
            Thread.Sleep(10);
            if (directory.FullName == string.Empty)
                return;

            PrintFiles(directory.FullName, pos + 3);

            pos += 3;

            for (int i = 0; i < directory.GetDirectories().Length; i++)
            {
                Thread.Sleep(10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(new string(' ', pos) + directory.GetDirectories()[i].Name);
                folderCount++;
                Console.ForegroundColor = ConsoleColor.Gray;

                try
                {
                    PrintFolders(directory.GetDirectories()[i], pos);
                }
                catch (Exception e) when (e is PathTooLongException || e is UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void PrintFiles(string filePath, int pos)
        {
            DirectoryInfo directory = new DirectoryInfo(filePath);

            if (directory.GetFiles().Length == 0)
                return;

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (FileInfo item in directory.GetFiles())
            {
                Console.WriteLine(new string(' ', pos) + item.Name);
                fileCount++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            string path = @"C:\";
            DirectoryInfo directory = new DirectoryInfo(path);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green -> Folder");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red -> File");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(path);
            PrintFolders(directory);

            Console.WriteLine("Files count: {0}\nFolders count: {1}", fileCount, folderCount);
            Console.ReadKey();
        }
    }
}
