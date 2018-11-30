using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotds2
{
    public class Program
    {
        
        /// <summary>
        /// Type 1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ConvertToBinary(int number)
        {
            return Convert.ToString(number,2);
        }

        /// <summary>
        /// Type 2
        /// </summary>
        /// <param name="text"></param>
        static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Type 3
        /// </summary>
        /// <returns></returns>
        static double GetPi()
        {
            return Math.PI;
        }

        /// <summary>
        /// Type 4
        /// </summary>
        static void PrintIntMaxValue()
        {
            Console.WriteLine(int.MaxValue);
        }

        static void Delay()
        {
            Console.ReadKey();
        }
        

        static void Main(string[] args)
        {
            //Type 1 
            string convertToBinary = ConvertToBinary(8);
            Console.WriteLine(convertToBinary);
            
            //Type 2
            PrintText("Hello");

            //Type 3
            double pi = GetPi();
            Console.WriteLine(pi);

            //Type 4
            PrintIntMaxValue();

            //Type 4
            Delay();
        }
    }
}
