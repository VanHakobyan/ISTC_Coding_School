using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.ExceptionHandling
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }

    //Kelvin temperature scale
    public class Temperature
    {
        public int temperature = 0;

        public void ShowTemp()
        {

            if (temperature == 0)
            {
                TempIsZeroException z = new TempIsZeroException("Zero Temperature found")
                {
                    HelpLink = "Fb.com"
                };

                throw z;
            }
            else
            {
                Console.WriteLine($"Temperature: {temperature}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            temp.temperature = 0;
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine($"TempIsZeroException: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
