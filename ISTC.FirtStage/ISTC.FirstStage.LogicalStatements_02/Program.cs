using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.LogicalStatements_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolText = Console.ReadLine();
            int number = Convert.ToInt32(boolText);

            if (number >= 0)
            {
                Console.WriteLine("number more than 0 or equal");
            }
            else if (number <= 0)
            {
                Console.WriteLine("number less than 0 or equal");
            }
          



            Console.ReadKey();
        }
    }
}
