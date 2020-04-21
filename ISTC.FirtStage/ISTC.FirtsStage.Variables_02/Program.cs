using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirtsStage.Variables_02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte year;

            year = 26;

            year = 75;

            //Console.WriteLine(year);
            //____

            int readBooksCount = 16;

            readBooksCount = 17;
            readBooksCount = readBooksCount + 1;
            readBooksCount += 1;
            readBooksCount++;//go next line and add readBookCount 
            ++readBooksCount;//add readBookCount  and go next line 

            Console.WriteLine(readBooksCount);
            Console.WriteLine(readBooksCount--);
            Console.WriteLine(readBooksCount);
            Console.WriteLine(++readBooksCount);

            float f = 1.5f;
            double s = 1.5;
            decimal d = 1.5m;

            char a = 'a';
            char A = 'A';

            Console.WriteLine(new string('-', 50));

            Console.WriteLine((int)a);
            Console.WriteLine((int)A);
            Console.WriteLine((int)'0');


            const string firstName = "Robert";
            //firstName += "h";
            string lastName = "Kocharyan";
            string middleName = "Vova";
            string fullNameConcat = firstName + middleName + lastName;//concatenation //bad practice
            string fullNameFormat = string.Format("{0} {1} {2}", firstName, middleName, lastName);
            string fullName = $"{firstName} {middleName} {lastName}";//interpolation 

        }
    }
}
