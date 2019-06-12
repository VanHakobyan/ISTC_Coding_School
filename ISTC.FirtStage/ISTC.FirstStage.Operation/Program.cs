using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FirstStage.Operation
{
    //1. ++,-- inc,dec
    //2. Local Global
    //3. Math
    //4. Comparison
    //5. Checket
    //6. Concotenation
    //7. String Format
    //8. Sizeof
    //9. Var
    class Program
    {
        static void Main(string[] args)
        {
            //7. String Format
            Console.WriteLine("Barev es {0} em {1} tarekan", "Van", 30);
            Console.ReadKey();
            //6. Concotenation
            string firstName = "Robert";
            string lastName = "Kocharyan";
            string whiteSpace = " ";
            string n = "\n";
            string name = firstName + n + lastName + "\n" + "azatutyun naxagahiun"; //Concotenation
            Console.WriteLine(name);

            Console.ReadKey();
            //5. Checket
            byte by = 255;

            checked
            {
                unchecked
                {
                    by += 1;
                }
            }
            Console.WriteLine(by);
            Console.ReadKey();

            //4. Comparison
            int n1 = 26;
            int n2 = 26;
            bool b = n1 != n2;
            Console.WriteLine(b);
            Console.ReadKey();

            //3. Math
            double pi = Math.PI;
            double pow = Math.Floor(1.53468464);
            Console.WriteLine(pow);
            Console.ReadKey();
            //2.  Local Global
            int k = 4;
            {
                //int k = 4;
                int x = 5;
            }

            {
                int x = 6;
            }

            //1.++,--
            int number = 5;

            Console.WriteLine(--number);//number=number-1;  cw(number)
            Console.WriteLine(number--);//cw(number);       number=number-1;
            Console.WriteLine(number);//3
            Console.ReadKey();
            //number = number + 1;
        }
    }
}
