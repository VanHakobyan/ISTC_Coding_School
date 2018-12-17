using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            WesternAlphabet alphabetEnumerator =new WesternAlphabet();
            
            foreach (var item in alphabetEnumerator)
            {
                Console.WriteLine(item);
            }
        }
    }
}
