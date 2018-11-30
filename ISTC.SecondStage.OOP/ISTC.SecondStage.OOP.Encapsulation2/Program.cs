using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
    public class Mard
    {
        public Mard(string name, int age, int qash)
        {
            anun = name;
            tariq = age;
            Qash = qash;
        }

        private int Qash;
        private string anun;
        public int tariq;
        public void SayNameAndAge()
        {
            Console.WriteLine($"Es {anun}-n em {tariq} tarekan  !!!");
        }
        public void Method(string s)
        {
            anun = s;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Mard mard1 = new Mard("John", 45, 451);
            Mard mard2 = new Mard("Karen", 32, 78);
            mard1.Method("new name");

            Console.WriteLine(mard1.tariq);
            mard1.tariq = 567;

            Console.WriteLine(mard1.tariq);
            Console.WriteLine(mard2.tariq);

            mard1.SayNameAndAge();
            mard2.SayNameAndAge();
        }
    }
}
