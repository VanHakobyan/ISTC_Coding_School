using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.AMM01
{
    class A
    {
        ~A()
        {
            Console.WriteLine("Destruct instance of A");
            Thread.Sleep(1000);
        }
        public void F()
        {
            Console.WriteLine("A.F");
            Program.RefA = this;
        }
    }
    class B
    {
        public A Ref;
        ~B()
        {
            Console.WriteLine("Destruct instance of B");
            Ref.F();
            Thread.Sleep(1000);
        }
    }
}
