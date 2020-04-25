using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirtStage.Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            //=
            int x = 5;
            
            int t = x % 3;//modulus //1
            x %= 2;//x=x%2


            //+=, -=, *=, /=
            x += 3;//x=x+3
            x *= 3;//x=x*3
            x /= 3;//x=x/3
            x -= 3;//x=x-3
            
        }
    }
}
