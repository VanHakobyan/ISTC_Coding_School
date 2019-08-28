using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    interface IPhone
    {
        void Call();
        string Message(string message);
        void VideoCall();
    }


    class Phone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("call");
        }

        public string Message(string message)
        {
            return message;
        }

        public void VideoCall()
        {
            Console.WriteLine("video call");

        }
    }


    struct PhoneStruct : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Stack call !!!");
        }

        public string Message(string message)
        {
            return message.Substring(0, 5);
        }

        public void VideoCall()
        {
            Console.WriteLine("Stack video call");
        }
    }


    struct MyStruct
    {
        public static int staticField = 25;
        public int field;

        static MyStruct()
        {

        }

        public MyStruct(int z)
        {
            field = z;
        }
    }

    class A
    {
        private int x;
        private int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Plus()
        {
            x++;
            y++;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    struct B
    {
        public int x;
        public int y;

        public B(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Plus()
        {
            x++;
            y++;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }



    class Program
    {

        public static void CommonMethod(IPhone phone)
        {
            phone.VideoCall();
            phone.Call();
            string mes = phone.Message("I'm a Robert Kocharian!!!");
            Console.WriteLine(mes);
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Color color = Color.Black;
            DateTime dateTime = DateTime.MaxValue;

            string date = "14:15";
            var time = DateTime.ParseExact(date, "HH:mm", CultureInfo.InvariantCulture);
            var s = time.ToString("Y");
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(new Phone());
            //arrayList.Add(new PhoneStruct());

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    CommonMethod(arrayList[i] as IPhone);
            //}

            //A a = new A(10, 20);
            //a.Plus();
            //a.Print();

            //B b = new B(10, 20);
            //b.Plus();
            //b.Print();

            //MyStruct myStruct = new MyStruct(5);
            //Console.WriteLine(myStruct.field);
            Console.ReadKey();
        }
    }
}
