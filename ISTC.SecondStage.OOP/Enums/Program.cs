using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Week
    {
        Erkushabti = 1,
        Ereqshabti,
        Choreqshabti,
        Hingshabti,
        Shabat = 6,
        Kiraki
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDay = new string[7]
            {
                "Erkushabti",
                "Ereqshabti",
                "Choreqshabti",
                "Hingshabti",
                "Urbat",
                "Shabat",
                "Kiraki"
            };
            int choreqshabti = (int)Week.Choreqshabti;
            
            Week.TryParse<Week>("Erkushabti", out var res);
            Console.WriteLine(res);
            Console.WriteLine(weekDay[(int)Week.Choreqshabti-1]);

        }
    }
}
