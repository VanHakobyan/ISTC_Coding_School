using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.WorkWithText.Str
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "there is a cat, assa adda ,daa";
            // Split string on spaces (this will separate all the words).
            string[] words = data.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


            string dog = data.Replace("cat", "dog");
            bool endsWith = data.EndsWith("a");
            bool contains = data.Contains("ad");
            int indexOf = data.IndexOf("assa");
            string insert = data.Insert(indexOf, "YE0");
            string trim = data.Trim('\t');

        }
    }
}
