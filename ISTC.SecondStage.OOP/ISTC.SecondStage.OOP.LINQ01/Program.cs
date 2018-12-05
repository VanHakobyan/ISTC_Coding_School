using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.LINQ01
{
    class Program
    {
        public static void DoSomethig(dynamic myAnonymousType)
        {
            Console.WriteLine(myAnonymousType.secondProperty);
        }
        static void Main(string[] args)
        {
            var myAnonymousType = new
            {
                firstProperty = "First Property",
                secondProperty = 2,
                thirdProperty = true,
                anotherAnonymousType = new { nestedProperty = "Nested" }
            };

            DoSomethig(myAnonymousType);
        }
    }
}
