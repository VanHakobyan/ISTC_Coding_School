using System;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.R3
{
    class Program
    {
        const int x = 5;
        static void Main(string[] args)
        {

            Type type = x.GetType();
            Console.WriteLine(x.GetType().ToString());


            Console.WriteLine(type.Name);
            Console.WriteLine(type.ToString());
            Type intType = typeof(Task);

            Console.WriteLine(intType.Name);
            Console.WriteLine(intType.ToString());
        }
    }
}
