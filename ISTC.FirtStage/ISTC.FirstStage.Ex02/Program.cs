using System;

namespace ISTC.FirstStage.Ex02
{
    class Program
    {
        //Խնդիր_9:
        //Տրված է N բնական թիվը։ Հաշվել
        //1/2 + 1/3 + … + 1/N գումարը(այն իրական թիվ է)։

        static void Main(string[] args)
        {
            double sum = 1;
            int n = int.Parse(Console.ReadLine());
            for (double i = 2; i <= n; i++)
            {
                double current = 1.0 / i;
                sum += current;
            }

            Console.WriteLine(sum);
            Console.WriteLine(Math.Round(sum,0));
            Console.ReadKey();
        }
    }
}
