using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    interface IA
    {


        void M();
    }

    interface IB
    {
        void M();
    }

    class A : IA, IB, IEquatable<A>
    {
        public class MyClass
        {
             void Aa()
            {

            }
        }
        // int x;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        public void AA(int x = 5)
        {
        }

        //double AA()
        //{
        //    return 0;
        //}

        void IA.M()
        {
            Console.WriteLine("AA");
        }

        void IB.M()
        {
            Console.WriteLine("BB");
        }

        public bool Equals(A other)
        {
            return this == other;

            // throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            
            return base.Equals(obj);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var s1 = $"{"abc"}{"cba"}";
            var s2 = "abc" + "cba";
            var s3 = "abccba";
            var ss1= (object)s1.GetHashCode();
            var ss2= (object)s2.GetHashCode();
            var ss3= (object)s3.GetHashCode();
            Console.WriteLine(s1 == s2); // true
            Console.WriteLine((object)s2 == (object)s3); // false
            Console.WriteLine(s2 == s3); // true
            Console.WriteLine((object)s1 == (object)s2); // false

            Console.Read();
        }
    }
}
