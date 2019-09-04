using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Generics04
{
    public class MyC : ICloneable, IEnumerable
    {
        private MyC()
        {

        }

        public object Clone()
        {
            return new object();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    abstract class My : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    interface IInterface<T>
    {
        T GetValue();
        Task<T> GetValueAsync();
        T SetItem<M>(M m);
    }

    class MyClass<T> //where T : class, ICloneable, IEnumerable, new()
    {
        public MyClass(T val) { }

        public MyClass()
        {

        }
        public T GetValue()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetValueAsync()
        {
            throw new NotImplementedException();
        }

        public T SetItem<M>(M m)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<My> myClass = new MyClass<My>();
            MyClass<MyC> myClass1 = new MyClass<MyC>();

        }
    }
}
