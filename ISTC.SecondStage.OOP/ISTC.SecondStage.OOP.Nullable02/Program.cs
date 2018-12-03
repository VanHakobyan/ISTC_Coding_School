using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Nullable02
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number = 5;
            int? res = number.HasValue ? number : null;

            string[] arr = new string[3];


            if (arr != null && arr[2] != null)
            {
                int x = arr[2].Length;
            }
            int? y = arr?[2]?.Length.ToString()?.Length.ToString()?.Length;
        }
    }
}
