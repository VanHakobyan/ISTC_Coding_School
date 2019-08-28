using System;
using System.Configuration;
using System.IO;

namespace ISTC.ThirdStage.Advance.Configs.Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ConfigurationManager.AppSettings["Text"];
            Console.WriteLine(text);
            Console.ReadKey();

        }
    }
}
