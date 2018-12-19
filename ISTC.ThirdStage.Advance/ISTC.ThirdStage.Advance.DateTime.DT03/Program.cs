using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.DateTime.DT03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define two dates.  
            System.DateTime date1 = new System.DateTime(2018, 1, 10, 11, 20, 30);
            System.DateTime date2 = new System.DateTime(2018, 2, 20, 12, 25, 35);

            // Calculate the interval between the two dates.  
            TimeSpan interval = date2 - date1;

            // Display individual properties of the resulting TimeSpan object.  
            Console.WriteLine("No of Days:", interval.Days); // 41  
            Console.WriteLine("Total No of Days:", interval.TotalDays); // 41.0451  
            Console.WriteLine("No of Hours:", interval.Hours); //1  
            Console.WriteLine("Total No of Hours:", interval.TotalHours); // 985.084  
            Console.WriteLine("No of Minutes:", interval.Minutes); // 5  
            Console.WriteLine("Total No of Minutes:", interval.TotalMinutes); // 59105.833  
            Console.WriteLine("No of Seconds:", interval.Seconds); // 5  
            Console.WriteLine("Total No of Seconds:", interval.TotalSeconds); // 3546305.0  
            Console.WriteLine("No of Milliseconds:", interval.Milliseconds); // 0  
            Console.WriteLine("Total No of Milliseconds:", interval.TotalMilliseconds); // 3546305000  
            Console.WriteLine("Ticks:", interval.Ticks); // 354630500000000  
        }
    }
}
