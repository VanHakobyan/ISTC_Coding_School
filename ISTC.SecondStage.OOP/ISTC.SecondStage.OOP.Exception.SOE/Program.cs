using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Exception.SOE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = RecursiveMethod();
            }
            catch (System.Exception e)
            {

            }
            finally
            {

            }
        }


        private static int RecursiveMethod()
        {
            return RecursiveMethod();
        }
    }
}
