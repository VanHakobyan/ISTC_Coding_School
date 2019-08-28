using System;
using System.Threading;

namespace ISTC.ThirdStage.Advance.AMM.AMM01
{
    class My:IDisposable
    {
        ~My()
        {
            ReleaseUnmanagedResources();
        }

        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
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
