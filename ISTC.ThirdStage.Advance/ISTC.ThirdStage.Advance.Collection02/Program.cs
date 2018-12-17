using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection02
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> s = new List<string>();


            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "Zero");
            dictionary.Add(1, "One");
            //dictionary.Add(1,"Two");
            string s1 = dictionary[0];
            Console.WriteLine(s1);

            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            dictionary2.Add("0", "Zero");
            //string s2 = dictionary2["Zero"];
            var val = dictionary2.Values.ElementAt(0);


        }
    }
}
