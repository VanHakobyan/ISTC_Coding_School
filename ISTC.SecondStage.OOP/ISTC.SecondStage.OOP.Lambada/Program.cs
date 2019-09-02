using System;

namespace ISTC.Lambada
{
    public delegate double Calculate(float num);
    public delegate void Print();


    class Program
    {
        /// <summary>
        /// explicit static method
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns></returns>
        public static double Method(float n)
        {
            return n * n;
        }

        //public static double Method1(float n) => n* n;


        static void Main(string[] args)
        {
            //Calculate calculate= new Calculate(Method);

            Calculate calculate0 = Method; // Method explicit 

            // Lambada
            Calculate calculate1 = delegate (float n) { return n * n; };            // Method
            Calculate calculate2 = (n) => { Console.WriteLine(); return n * n; };   // Operator
            Calculate calculate3 = (n) => n * n;                                    // Expression

            Print p = () => Console.WriteLine();
            //calculate1=calculate1=calculate1 
        }
    }

}