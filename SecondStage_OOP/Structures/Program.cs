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

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(5);
            Console.WriteLine(myStruct.field);
            Console.ReadKey();
        }
    }
}
