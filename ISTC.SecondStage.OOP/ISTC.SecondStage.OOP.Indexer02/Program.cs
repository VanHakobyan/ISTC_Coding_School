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
            set
            {
                nextIndex = i;
                arr[i] = value;
            }
        }

        public void Add(T value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            if (nextIndex < arr.Length - 1)
            {
                nextIndex++;
                arr[nextIndex] = value;
            }

        }

        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = default(T);
                nextIndex = default(int);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection<string>();

            //stringCollection[25] = "Hello, World";
            //stringCollection[26] = "Hello, World";
            //stringCollection[27] = "Hello, World";
            //stringCollection[28] = "Hello, World";

            stringCollection.Add("World");

            Console.WriteLine(stringCollection[0]);//
            Console.WriteLine(stringCollection[2]);//
            Console.WriteLine(stringCollection[1]);//
        }
    }
}
