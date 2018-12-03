using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.RefOut
{
    class MyClass
    {
        public int Number { get; set; }
    }
    class Program
    {
        public static int Method(int x)
        {
            return ++x;
        }

        public static int Method2(ref int x)
        {
            return ++x;
        }

        public static int MethodRef(MyClass myClass)//myClass referance = 1231564231564
        {
            myClass = new MyClass();////myClass referance = 45656456
            return ++myClass.Number;
        }

        public static int MethodRef2(ref MyClass myClass)//myClass referance = 46104728
        {
            Console.WriteLine(myClass.GetHashCode());
            myClass = new MyClass();////myClass referance = 1231564231564
            Console.WriteLine(myClass.GetHashCode());
            return ++myClass.Number;
        }

        public static int MethodOut(out int x)
        {
            x = 45;
            return x * x;
        }

        public static string MethodParams(string s, params int[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(i);
            }
            return s;
        }
        static void Main(string[] args)
        {
            //referrence
            //ref        //out
            int x = 5;

            int res = Method(x);// x is by value
            Console.WriteLine($"res= {res}");
            Console.WriteLine($"x= {x}");

            int res2 = Method2(ref x);  // x is by reference 
            Console.WriteLine($"res= {res2}");
            Console.WriteLine($"x= {x}");

            MyClass myClass = new MyClass();

            Console.WriteLine(myClass.GetHashCode());
            MethodRef2(ref myClass);
            Console.WriteLine(myClass.GetHashCode());
            Console.WriteLine($"myClass.Number={myClass.Number}");
            int k;
            int resOut = MethodOut(out k);
            

            Console.WriteLine($"k={k}");
            Console.WriteLine($"resOut={resOut}");

            MethodParams("s", 132, 31, 23, 165, 4, 32, 1, 654, 32, 156, 4, 23, 486, 54, 564);
            

        }
    }
}
