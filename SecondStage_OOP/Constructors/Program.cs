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
        private string name;
        private int age;
        private string gender;

        //string MyClass()
        //{

        //}

        static MyClass()
        {
            type = "Human";
        }

        public MyClass(string name)
        {
            this.name = name;
        }
        //public MyClass(string name,int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}
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
            MyClass.type = "Kapik";
            MyClass myClass = new MyClass("z");

            MyClass myClass2 = new MyClass("a");
            Console.WriteLine(MyClass.type);

        }
    }
}
