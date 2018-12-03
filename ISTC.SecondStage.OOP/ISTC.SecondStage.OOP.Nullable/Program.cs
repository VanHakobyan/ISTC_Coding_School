using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;// T?=Nullable<T> 
            Nullable<int> y = 5;

            if (x.HasValue)
            {
                x++;
            }
            else
            {
                x = y;
                int t = x.Value;//null.Value;
            }
        }
    }
}
