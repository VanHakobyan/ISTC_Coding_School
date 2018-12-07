using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Extension01
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value) //this  - syntax sugar 
        {
            return i > value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int element = 5;
            var isGreaterThan = element.IsGreaterThan(100);
            Console.WriteLine($"isGreaterThan? - {isGreaterThan}");
        }
    }
}