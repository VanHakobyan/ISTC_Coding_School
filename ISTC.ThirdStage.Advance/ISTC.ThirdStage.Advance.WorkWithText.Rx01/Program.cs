using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.WorkWithText.Rx01
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "4 AND 5";

            //var matches = Regex.Matches(value, @"\d").Cast<Match>().Select(x=>x.Groups[0].Value).ToList();
            

            // Get first match.
            Match match = Regex.Match(value, @"\d");
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

            // Get second match.
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
