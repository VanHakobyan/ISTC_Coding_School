using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICommunicate
    {
                void Voice();
    }

    public interface ICom2
    {
        void Voice();
    }
    public class MyClass : ICom2, ICommunicate
    {
        void ICom2.Voice()
        {

        }

        void ICommunicate.Voice()
        {

        }
    }

    public class Dog : ICommunicate, IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Maqrac e");
        }

        public void Voice()
        {
            Console.WriteLine("Haf Haf");
        }
    }
    public class Horse : ICommunicate
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

            ICommunicate myClass = new MyClass();
            myClass.Voice();

            ICom2 myClass2 = new MyClass();
            myClass2.Voice();

            Dog dog;
            using (dog = new Dog())
            {
                dog.Voice();
            }//dog1.Dispose();

            dog.Voice();
            //using (Horse horse=new Horse())
            //{
            //     error
            //}

            Horse horse = new Horse();

            Say(dog);   //upcast
            Say(horse); //upcast

        }
    }
}
