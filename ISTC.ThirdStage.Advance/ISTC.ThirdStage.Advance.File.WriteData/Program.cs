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
            FileStream fs = new FileStream("E://data.txt", FileMode.Append, FileAccess.Write);
            StreamWriter w = new StreamWriter(fs);
            Console.WriteLine("Enter the string");
        
            string str = Console.ReadLine();
            w.Write(str);
            w.Flush();
            fs.Close();

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.WriteData();
            Console.Read();
        }
    }
}
