using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = Convert.ToInt32(Console.ReadLine());//2341
            Console.WriteLine("---------");

            int lastNumber4 = number % 10;      //1
            int newNumber3 = number / 10;       //234
            int lastNumber3 = newNumber3 % 10;  //4
            int newNumber2 = newNumber3 / 10;   //23
            int lastNumber2 = newNumber2 % 10;  //3
            int numNumber1 = newNumber2 / 10;   //2
            int lastNumber1 = numNumber1 % 10;  //2

            int result = lastNumber1 + lastNumber2 + lastNumber3 + lastNumber4;
            string text = "Result=" + result;
            Console.WriteLine(text);
        }
    }
}
