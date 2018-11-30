using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldenApple goldenApple = new GoldenApple("golden", "Yellow");

            NorTarvaSexaniApple norTarvaSexaniApple = new NorTarvaSexaniApple("nor tarva", "red");
            AbstractApple abstractApple = null; //base
            //abstractApple = (AbstractApple)demirApple;
            //norTarvaSexaniApple = (NorTarvaSexaniApple)abstractApple;

            int number = 0;
            Console.Write("Num: ");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: abstractApple = goldenApple; break;
                case 2: abstractApple = new DemirApple("demir", "green"); ; break;
                case 3: abstractApple = norTarvaSexaniApple; break;
                default: break;

            }

            Console.WriteLine($"Color {abstractApple.GetColor()}");
            Console.WriteLine($"AppleType {abstractApple.GetAppleType()}");
            GoldenApple goldenApple1 = (GoldenApple)abstractApple;
            int x = goldenApple1.MyProperty;
            int a = goldenApple.MyProperty;
        }
    }
}
