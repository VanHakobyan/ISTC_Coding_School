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

        public static bool IsOnlyLowerCharacters(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 'a' || s[i] > 'z') return false;
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var s = Console.ReadLine();
                bool isOnlyLowerCharacters = s.IsOnlyLowerCharacters();
                Console.WriteLine(isOnlyLowerCharacters);
            }

            int e = 5;
            var isGreaterThan = e.IsGreaterThan(100);
            Console.WriteLine($"isGreaterThan? - {isGreaterThan}");
        }
    }
}