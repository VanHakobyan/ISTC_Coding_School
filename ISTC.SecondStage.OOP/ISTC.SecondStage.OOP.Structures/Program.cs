using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct MyStruct
    {

        public int field;
        static MyStruct()
        {

        }

        public MyStruct(int z)
        {
            field = z;
        }
    }

    class A
    {
        private int x;
        private int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Plus()
        {
            x++;
            y++;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    struct B
    {
        public int x;
        public int y;

        public B(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Plus()
        {
            x++;
            y++;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(10, 20);
            a.Plus();
            a.Print();

            B b=new B(10,20);
            b.Plus();
            b.Print();

            MyStruct myStruct = new MyStruct(5);
            Console.WriteLine(myStruct.field);
            Console.ReadKey();
        }
    }
}
