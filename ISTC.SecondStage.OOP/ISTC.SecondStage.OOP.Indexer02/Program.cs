using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Indexer02
{
    class SampleCollection<T>
    {

        private T[] arr = new T[100];
        int nextIndex = 0;

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public void Add(T value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";

            stringCollection.Add("World");

            Console.WriteLine(stringCollection[0]);
        }
    }
}
