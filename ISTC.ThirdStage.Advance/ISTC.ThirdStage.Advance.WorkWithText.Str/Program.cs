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
            string data = "there is a cat";
            // Split string on spaces (this will separate all the words).
            string[] words = data.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
