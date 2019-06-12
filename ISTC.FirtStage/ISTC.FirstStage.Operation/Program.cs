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
