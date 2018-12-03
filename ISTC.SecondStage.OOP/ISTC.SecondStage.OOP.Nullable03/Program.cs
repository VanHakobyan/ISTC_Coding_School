using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Nullable03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            string result = s ?? string.Empty;//"" or null

            int? k = null;
            double? d = null;
            k = 5;
            //int k = 2;
            //decimal d = .25m;

            if (d == k)
            {
                Console.WriteLine("if");
            }
            else
            {
                Console.WriteLine("else");
            }

        }
    }
}
