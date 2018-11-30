using System;

namespace Methods
{
    class Program
    {
        static int Add(int number1, int number2)
        {
            int result = number2 + number1;

            return result;
        }

        static long Add(long n2, long n1)
        {
            return n1+n2;
        }
       
        static decimal Add(decimal n2,decimal n1)
        {
            return n2+n1;
        }

        static byte Add(byte n2, byte n1)
        {
            return (byte)(n2+n1);
        }

        static byte Add(byte n2, byte n1,string name)
        {
            Console.WriteLine(name);
            return (byte)(n2 + n1);
        }

        static byte Add(byte n2, string str, string name)
        {
            Console.WriteLine(name);
            return (byte)(n2);
        }
        

        static void Main(string[] args)
        {
            
        }
    }
}
