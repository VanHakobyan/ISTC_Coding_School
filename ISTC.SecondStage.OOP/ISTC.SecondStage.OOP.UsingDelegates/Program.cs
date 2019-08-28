using System;
using System.IO;

namespace ISTC.UsingDelegates
{
    class PrintStringClass
    {
        private static FileStream _fs;
        private static StreamWriter _sw;

        public delegate void PrintString(string s);


        public static void WriteToScreen(string str)
        {
            Console.WriteLine($"The String is: {str}");
        }


        public static void WriteToFile(string s)
        {
            _fs = new FileStream(@"C:\Users\vanik.hakobyan\source\message.txt", FileMode.Append, FileAccess.Write);
            _sw = new StreamWriter(_fs);
            _sw.WriteLine(s);
            _sw.Flush();
            _sw.Close();
            _fs.Close();
        }


        public static bool SendString(PrintString ps)
        {
            ps.Invoke("Hello World");
            return true;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {



            PrintStringClass.PrintString ps1 = new PrintStringClass.PrintString(PrintStringClass.WriteToScreen);
            PrintStringClass.PrintString ps2 = new PrintStringClass.PrintString(PrintStringClass.WriteToFile);
            //ps1+=WriteToFile;

            bool flag1 = PrintStringClass.SendString(ps1);
            bool flag2 = PrintStringClass.SendString(ps2);

            Console.ReadKey();
        }
    }
}