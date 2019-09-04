namespace ISTC.SecondStage.OOP.Generics02
{
    class Program
    {
        static void Swap<T>(ref T first, ref T second)
        // static void Swap(ref int first, ref int second)
        {
            T temp;//int temp
            temp = first;
            first = second;
            second = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            char c = 'c';
            char d = 'd';
            //string s = "s";
            //string M = "m";

            //Swap(s, M);
            Swap<char>(ref d, ref c);
            Swap(ref a, ref b);
            //Console.WriteLine($"s={s}");
            //Console.WriteLine($"M={M}");

            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            //Console.WriteLine($"c={c}");
            //Console.WriteLine($"d={d}");
        }
    }
}
