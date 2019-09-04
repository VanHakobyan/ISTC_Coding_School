using System;

delegate T NumberChanger<T>(T n);
public delegate TResult FuncCustom<in T, out TResult>(T arg);

namespace ISTC.SecondStage.OOP.Generics03
{
    static class My
    {

    }
    class Program
    {
        public static TR GenericMethod<T, TR>(T r) where TR : class
        {
            return null;
        }
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }


        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            //calling the methods using the delegate objects
            nc1.Invoke(25);
            Console.WriteLine($"Value of Num: {GetNum()}");

            nc2(5);
            Console.WriteLine($"Value of Num: {GetNum()}");

            Console.ReadKey();
        }
    }
}
