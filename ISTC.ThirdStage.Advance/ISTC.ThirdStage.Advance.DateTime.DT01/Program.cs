using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.DateTime.DT01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime myDate = System.DateTime.Now;
            int year = myDate.Year;
            int month = myDate.Month; 
            int day = myDate.Day;
            int hour = myDate.Hour; 
            int minute = myDate.Minute; 
            int second = myDate.Second; 
            DayOfWeek weekDay = myDate.DayOfWeek; 
        }
    }
}
