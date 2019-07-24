using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Extension02
{
    public static class CommonUtil
    {
        public static string ListToString(this IList list)
        {
            var result = new StringBuilder("");

            if (list.Count > 0)
            {
                result.Append(list[0].ToString());//1
                for (int i = 1; i < list.Count; i++)
                {
                    result.AppendFormat(", {0}", list[i].ToString());//1, 2,3
                }
            }
            return result.ToString();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.AddRange(Enumerable.Range(10, 100));//[10,100)

            var any = list.Skip(10).Take(10).OrderBy(x=>x).ToList();
            string result = list.ListToString();
            Console.WriteLine(result);
            Console.WriteLine(list.ToString());
        }
    }
}
