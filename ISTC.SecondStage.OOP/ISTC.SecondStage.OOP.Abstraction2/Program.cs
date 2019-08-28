using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Abstraction2
{
    abstract class Animal
    {

        public int x;
        protected Animal()
        {
            x = 5;
        }
        //public abstract void Move();
        public virtual void Move()
        {
            this.Move();
        }

        public void Voice()
        {
            Console.WriteLine("voice");
        }

    }

    class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Cat move!!!");
        }


    }

    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Dog move!!!");
        }
    }
    class Program
    {
        public static void Action(Animal c)
        {
            c.Move();
        }


        static void Main(string[] args)
        {
            Action(new Cat());
            Action(new Dog());

            Console.ReadKey();
        }
    }
}
