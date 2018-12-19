using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.File.ReadData
{
    class Program
    {
        public void ReadData()
        {
            FileStream fs = new FileStream("E:\\data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ReadData();
            Console.Read();
        }
    }
}
