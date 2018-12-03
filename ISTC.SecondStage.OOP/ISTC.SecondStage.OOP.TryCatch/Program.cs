using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            char? firstNumber = null;
            try
            {
                firstNumber = char.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
            Console.WriteLine(firstNumber);
        }
    }
}
