using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class MyClass
    {
        public static string type;//type => ?
        private int age = 5;
        private string gender;

        public const float pi = 3.14f;

        public string Name { get; set; }
        //public string Name { get; private set; }

        //static MyClass()
        //{

        //}

        static MyClass()
        {
            type = "Human";
            Console.WriteLine(type);
        }

        public MyClass(string name)
        {
            this.Name = name;
        }

        public MyClass(string name, int age) : this(name)
        {
            this.age = age;
        }

        public MyClass(string name, string gender) : this(name)
        {
            this.gender = gender;
        }

        public MyClass(string name, string gender, int age) : this(age: age, name: name)
        {
            this.gender = gender;
        }
    }
    class Program
    {
      static void Main(string[] args)
        {
            var sum = CS.lib.Math.Sum(5, 5);

            MyClass myClass2 = new MyClass("Robert", 61);

            Console.WriteLine(myClass2.Name);

            myClass2.Name = "New Rob";

            MyClass myClass3 = new MyClass("Robert", "M", 61);

            Console.ReadKey();
        }
    }
}
