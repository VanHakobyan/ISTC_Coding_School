using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var bin = 0b110_0000_0001_1001;
            var s = bin.ToString();
            Console.WriteLine(s);
            Console.ReadKey();

            uint x = 7;
            uint y = (x << 31);
            uint z = y >> 31;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            //--------------------------

            //1-7 , 2 6,7

            char weekDay = Convert.ToChar(Console.ReadKey().KeyChar);//week day
            Console.WriteLine();


            //bad practice 

            //if (char.IsDigit(weekDay))
            //{
            //    if (weekDay != 2)
            //    {
            //        if (weekDay != 6)
            //        {
            //            if (weekDay != 7)
            //            {
            //                Console.WriteLine("arrived");
            //            }
            //        }
            //    }
            //}

            if (char.IsDigit(weekDay))
            {
                //int weekDayInt = Convert.ToInt32($"{weekDay}");

                if (weekDay == '2' || weekDay == '6' || weekDay == '7')
                {
                    Console.WriteLine("not arrived");
                }
                else
                {
                    Console.WriteLine("arrived");
                }
            }
            else
            {
                Console.WriteLine("Is not digit !!!");
            }
        }
    }
}
