using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.File.WriteData
{
    class Program
    {
        public void WriteData()
        {
            using (FileStream fs = new FileStream("E://data.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter w = new StreamWriter(fs))
            {
                Console.WriteLine("Enter the string");

                string str = Console.ReadLine();
                w.Write(str);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.WriteData();
            Console.Read();
        }
    }
}
