using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.TPL.TPL07
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3]
            {
                Task.Factory.StartNew(() => MethodA()),
                Task.Factory.StartNew(MethodB),
                Task.Factory.StartNew(() => MethodC())
            };

            //Block until all tasks complete.
            Console.WriteLine("Main: Block");
            Task.WaitAll(tasks);
            Console.WriteLine("Main: Continue");

            Console.ReadKey();
        }

        private static void MethodC()
        {
            CommonMethod(1000, MethodBase.GetCurrentMethod().Name);
        }

        private static void MethodB()
        {
            CommonMethod(2000, MethodBase.GetCurrentMethod().Name);
        }

        private static void MethodA() => CommonMethod(3000, MethodBase.GetCurrentMethod().Name);




        private static void CommonMethod(int sleep, string methodName)
        {
            Task.Delay(sleep).GetAwaiter().GetResult();
            Console.WriteLine($"{methodName}: Task slipped {sleep / 1000} second");
        }
    }
}
