using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Indexer01
{
    class StringDataStore
    {

        private readonly string[] _array; // internal data storage
        public StringDataStore(int count)
        {
            _array = new string[count];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _array.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return _array[index];
            }

            set
            {
                if (index < 0 || index >= _array.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                _array[index] = value;
            }
        }

        public string this[string index]
        {
            get
            {
                if (string.IsNullOrEmpty(index))
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return _array[int.Parse(index)];
            }

            set
            {
                if (string.IsNullOrEmpty(index))
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                _array[int.Parse(index)] = value;
            }
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore(150);

            strStore["0"] = "Zero";
            strStore[0] = "One";

            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(strStore[i]);
            }
        }
    }
}
