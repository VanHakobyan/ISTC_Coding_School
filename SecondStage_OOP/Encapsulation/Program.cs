using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        static Person()
        {

        }

        public Person()
        {

        }


        public string LastName { get; set; }
        public int Age { get; set; }

        //    public Person(string fn, string ln, int age)
        //    {
        //        FirstName = fn;
        //        LastName = ln;
        //        Age = age;
        //    }

        //public string GetName()
        //{
        //    return FirstName;
        //}
        //public void SetName(string fn)
        //{
        //    FirstName = fn;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Person person = new Person()
            {
                //FirstName = "fn",
                LastName = "last",
                Age = 87,
            };



        }
    }
}
