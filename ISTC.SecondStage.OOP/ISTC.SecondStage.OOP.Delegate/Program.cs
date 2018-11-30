using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.Delegate
{
    class Program
    {
        public delegate string MyDelegate1(int x, string s);
        public delegate string MyDelegate2(int x, string s);

        public static string MyMethod1(int x, string s)
        {
            Console.WriteLine(x);
            return s;
        }
        public static string MyMethod2(int x, string s)
        {
            Console.WriteLine(x + 1);
            return s + "1";
        }

        static void Main(string[] args)
        {

            MyDelegate1 myDelegate1 = new MyDelegate1(MyMethod1);
            MyDelegate1 myDelegate2 = new MyDelegate1(MyMethod2);
            MyDelegate1 mydel = myDelegate1 + myDelegate2;
            mydel.Invoke(5,"Han");

        }
    }
}
