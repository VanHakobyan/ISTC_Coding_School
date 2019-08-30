using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Anonymous
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("myMethod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var m = new MyClass();
            m.Method(); 

            new MyClass().Method();

            var people = new
            {
                FirstName = "Robert",
                LastName = "Kocharian",
                Age = 64,
                Cars = new
                {
                    Model = "BMW",
                    Year = 2011,
                    HP = 350
                }
            };
            var lastName = people.Cars.HP;
        }
    }
}
