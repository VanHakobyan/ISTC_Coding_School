using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    internal class Builder
    {
        private int I { get; set; }
        private protected static Table[] Build()
        {
            Table[] tables = new Table[12];
            for (int i = 0; i < 12; i++)
            {
                tables[i] = new Table
                {
                    Hour = 2,
                    Lesson = Path.GetRandomFileName(),
                    Number = i + 1
                };
            }
            return tables;
        }

        private protected class Table
        {
            public int Number { get; set; }
            public string Lesson { get; set; }
            public int Hour { get; set; }
        }

        public static void Print()
        {
            Table[] tables = Build();
            Console.WriteLine("Number   Lesson   Hour");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i <= 11; i++)
            {
                Console.WriteLine($"{tables[i].Number} |{tables[i].Lesson}|{tables[i].Hour}");
            }
        }
    }
}
