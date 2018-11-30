using System;
using System.IO;

namespace ISTC.UsingDelegates
{
    class PrintStringClass
    {
        static FileStream fs; 
        static StreamWriter sw; 

        public delegate void PrintString(string s);


        public static void WriteToScreen(string str)
        {
            Console.WriteLine($"The String is: {str}");
        }


        public static void WriteToFile(string s)
        {
            fs = new FileStream(@"C:\Users\vanik.hakobyan\source\message&amp;.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }


        public static bool sendString(PrintString ps)
        {
            ps.Invoke("Hello World");
            return true;
        }


        class Program
        {
            unsafe static void FastCopy(byte[] src, byte[] dst, int count)
            {
                
            }
            static void Main(string[] args)
            {
               


                PrintString ps1 = new PrintString(WriteToScreen);
                PrintString ps2 = new PrintString(WriteToFile);
                //ps1+=WriteToFile;

                bool flag1 = sendString(ps1);
                bool flag2 = sendString(ps2);

                Console.ReadKey();
            }
        }
    }
}