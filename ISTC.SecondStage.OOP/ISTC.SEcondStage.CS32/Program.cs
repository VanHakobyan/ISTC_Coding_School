using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SEcondStage.CS32
{
    class Program
    {
        bool stringsRearrangement(string[] inputArray)
        {
            //while ((inputArray[0], inputArray[inputArray.Length-1]))
            {
                bool flag = true;
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    int c = 0;
                    for (int j = 0; j < inputArray[i].Length; j++)
                        if (inputArray[i][j] != inputArray[i + 1][j]) c++;
                    if (c != 1) flag = false;
                }
                if (flag) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
