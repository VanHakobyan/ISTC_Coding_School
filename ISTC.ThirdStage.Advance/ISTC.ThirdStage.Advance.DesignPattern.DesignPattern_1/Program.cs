using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.DesignPattern.DesignPattern_1
{
    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Transaction
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public string TransactionHistory { get; set; }
    }


    class Root
    {
        public int Id { get; set; }
        public string TransactionHistory { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PeopleId { get; set; }
    }


    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Root Factory(People p, Transaction t)
        {
            return new Root
            {
                Id = 1,
                Age = p.Age,
                Name = p.Name,
                PeopleId = p.Id,
                TransactionHistory = t.TransactionHistory,
            };
        }
        static void Main(string[] args)
        {
            var p = new People();
            var p1 = new People();
            var p2 = new People();
            var p3 = new People();
            var t = new Transaction();
            var t1 = new Transaction();
            var t2 = new Transaction();
            var t3 = new Transaction();

            Root r1 = Factory(p,t);
            Root r2 = Factory(p1,t1);
            Root r3 = Factory(p2,t2);
            Root r4 = Factory(p3,t3);
        }
    }
}
