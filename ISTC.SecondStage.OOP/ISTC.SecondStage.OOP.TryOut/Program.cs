using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.TryOut
{
    class Program
    {
        public static bool TryParsInt(string s, out int result)
        {            
            try
            {
                result = int.Parse(s);
                return true;
            }
            catch(Exception e)
            {
                result = default(int);
                return false;
            }
        }
        static void Main(string[] args)
        {
            if (int.TryParse("45564786", out int res))
            {
                Console.WriteLine(res);
            }
            


            if (TryParsInt("fvsdg", out int res1))
            {
                Console.WriteLine(res1);
            }
            

        }
    }
}
