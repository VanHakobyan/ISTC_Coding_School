using System.Linq;

namespace ISTC.ThirdStage.Advance.File.FileInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!System.IO.File.Exists(@"E:\Soursetest\Text.txt"))
            {
                System.IO.File.Create(@"E:\Soursetest\Text.txt");
            }


            System.IO.File.WriteAllLines(@"E:\Soursetest\Text.txt", Enumerable.Range(0, 100).Select(x => x.ToString()));

            string text = System.IO.File.ReadAllText(@"E:\Soursetest\Text.txt");

        }
    }
}
