using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    public interface ICommunicate
    {
        void Voice();
    }

    public class Cat : ICommunicate
    {
        public void Voice()
        {
            Console.WriteLine("Myau");
        }
    }

    public struct Dog : ICommunicate
    {
        public void Voice()
        {
            Console.WriteLine("Haf Haf");
        }
    }
    public struct Horse : ICommunicate
    {
        public void Voice()
        {
            Console.WriteLine("Xrxnj");
        }
    }

    class Program
    {
        public static void Say(ICommunicate communicate)
        {
            communicate.Voice();
        }
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //LinkedList<int> l = new LinkedList<int>();
            //IEnumerable<int> a = l;
            //var b = list as IEnumerable<int>;
        

            Dog dog = new Dog();
            Horse horse = new Horse();

            Cat cat = new Cat();
            ICommunicate iCat = cat as ICommunicate;  //explicit boxing
            Say(iCat);

            ICommunicate iDog = dog as ICommunicate;  //explicit boxing
            Say(iDog);

            ICommunicate iHorse = horse;              //implicit boxing
            Say(iHorse);
            Say(horse);   //implicit boxing


            Horse horse1 = (Horse)iHorse; //unboxing
            Dog dog1 = (Dog)iHorse; //unboxing //exception
        }
    }
}
