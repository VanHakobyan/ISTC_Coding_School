using System;
using System.Configuration;
using System.IO;

namespace ISTC.ThirdStage.Advance.Configs.Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(ConfigurationManager.AppSettings["path"]);
            Console.WriteLine(text);
            Console.ReadKey();

        }
    }
}
