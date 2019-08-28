using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class Ab
    {
        public static int x = 5;
        public virtual void Method() { }
    }

    public class B : Ab
    {
        public new int x = 1;

        public new void Method()
        {
        }
    }
    interface IInterface
    {
        void M();
    }

    interface IInterface2
    {
        void M1();
    }

    interface IInterface3 : IInterface, IInterface2
    {

    }
    abstract class MyClass : IInterface3
    {
        public abstract void M();
        public abstract void M1();

    }


    public class HttpHandler : IDisposable
    {
        private readonly string url;
        private HttpClient client = new HttpClient();

        public HttpHandler()
        {
            url = @"https://google.com";
        }


        public string SendGetRequest()
        {
            return client.GetStringAsync(url).Result;
        }

        public void CreateNew()
        {
            client = new HttpClient();
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed");
            client.Dispose();
        }
    }

    public interface ICommunicate
    {
        /*public abstract*/
        void Voice();
        int VoiceCount();
    }



    public interface ICom2
    {
        void Voice();
    }
    public class Communicate : ICom2, ICommunicate
    {
        void ICom2.Voice()
        {
            Console.WriteLine("ICom2.Voice()");
        }


        void ICommunicate.Voice()
        {
            Console.WriteLine("ICommunicate.Voice()");

        }
        public int VoiceCount()
        {
            return 1;
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

        public int VoiceCount()
        {
            throw new NotImplementedException();
        }
    }
    public class Horse : ICommunicate
    {
        public void Voice()
        {
            Console.WriteLine("Xrxnj");
        }

        public int VoiceCount()
        {
            throw new NotImplementedException();
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
            ICommunicate myClass = new Communicate();
            myClass.Voice();

            ICom2 myClass2 = new Communicate(); ;
            myClass2.Voice();


            Dog dog;
            using (dog = new Dog())
            {
                dog.Voice();
            }//dog.Dispose();

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
