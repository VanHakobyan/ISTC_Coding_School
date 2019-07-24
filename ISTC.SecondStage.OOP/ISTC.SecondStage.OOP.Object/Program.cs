using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Object
{
    public class CustomClass:System.Object
    {
        public int x;
        public override string ToString()
        {
            string s = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass customClass1 = new CustomClass();

            CustomClass customClass2 = customClass1;

            //customClass2.x = 5;
            customClass1.x = 5;
            Console.WriteLine(customClass2.x);

            bool b = customClass1.Equals(customClass2);

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
