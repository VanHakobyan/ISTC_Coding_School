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

            if (temperature <= 0)
            {
                TempIsZeroException z = new TempIsZeroException("Zero Temperature found")
                {
                    HelpLink = "https://istc.am"
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
            //using ()
            {
                //logic
            }//dispose

            try
            {
                //logic
            }
            finally
            {
                //dispose
            }


            Temperature temp = new Temperature();
            temp.temperature = 0;
            try
            {
                temp.ShowTemp();
            }
            catch (Exception e) when (e is TempIsZeroException)
            {
                Console.WriteLine($"TempIsZeroException: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
