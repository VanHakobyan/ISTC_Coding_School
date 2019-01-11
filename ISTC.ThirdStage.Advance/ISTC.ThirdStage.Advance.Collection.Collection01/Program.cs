using System;

namespace ISTC.ThirdStage.Advance.Collection.Collection01
{
    class Program
    {
        static void Main(string[] args)
        {
            WesternAlphabet alphabetEnumerator = new WesternAlphabet();

            foreach (var item in alphabetEnumerator)
            {
                Console.WriteLine(item);
            }
           
            foreach (string item in alphabetEnumerator)
            {
                Console.WriteLine(item);
            }


        }
    }
}
