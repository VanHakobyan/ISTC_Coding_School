using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryInternal;
using Constructors3;
using Console = System.Console;

namespace Constructors3
{
    internal class MyClass
    {
        public static int X { get; set; }

        protected internal MyClass(int x)
        {

        }

        
        static void Method()
        {
            Console.WriteLine("1651");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 myClass = new MyClass2();
        }
    }
}


