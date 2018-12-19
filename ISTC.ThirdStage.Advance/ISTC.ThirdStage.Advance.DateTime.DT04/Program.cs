using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.DateTimes.DT04
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple example.
            string simpleTime = "1/1/2000";
            DateTime time = DateTime.Parse(simpleTime);
            Console.WriteLine(time);

            // Taken from HTTP header
            string httpTime = "Fri, 27 Feb 2009 03:11:21 GMT";
            time = DateTime.Parse(httpTime);
            Console.WriteLine(time);

            // Taken from w3.org
            string w3Time = "2009/02/26 18:37:58";
            time = DateTime.Parse(w3Time);
            Console.WriteLine(time);

            // Taken from nytimes.com
            string nyTime = "Thursday, February 26, 2009";
            time = DateTime.Parse(nyTime);
            Console.WriteLine(time);

            // Taken from this site
            string perlTime = "February 26, 2009";
            time = DateTime.Parse(perlTime);
            Console.WriteLine(time);

            // Taken from ISO Standard 8601 for Dates
            string isoTime = "2002-02-10";
            time = DateTime.Parse(isoTime);
            Console.WriteLine(time);

            // Taken from Windows file system Created/Modified
            string windowsTime = "2/21/2009 10:35 PM";
            time = DateTime.Parse(windowsTime);
            Console.WriteLine(time);

            // Taken from Windows Date and Time panel
            string windowsPanelTime = "8:04:00 PM";
            time = DateTime.Parse(windowsPanelTime);
            Console.WriteLine(time);



            string dateString = "Mon 16 Jun 8:30 AM 2008"; 
            string format = "ddd dd MMM h:mm tt yyyy";
            DateTime dateTime = DateTime.ParseExact(dateString, format,CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime);


            string dateString2 = null;
            // Convert a null string.  
            DateTime dateTime10;
            bool isSuccess = DateTime.TryParse(dateString2, out dateTime10); // 1/1/0001 12:00:00 AM 
            Console.WriteLine(dateTime10);


            dateString = "Tue Dec 30, 2015";
            DateTime dateTime12;
            bool isSuccess2 = DateTime.TryParse(dateString, out dateTime12); // 1/1/0001 12:00:00 AM  
            Console.WriteLine(dateTime12);





            dateString = null;
            CultureInfo provider = CultureInfo.InvariantCulture;
            bool isSuccess3 = DateTime.TryParseExact(dateString, "MM/dd/yyyy", provider, DateTimeStyles.None, out var dateTime5);

            dateString = "not a date";
            // Exception: The string was not recognized as a valid DateTime. There is an unknown word starting at index 0.  
            bool isSuccess4 = DateTime.TryParseExact(dateString, "MM/dd/yyyy", provider, DateTimeStyles.None, out var dateTime4);

            dateString = "Tue Dec 30, 2015";
            // Exception: String was not recognized as a valid DateTime because the day of week was incorrect.  
            bool isSuccess5 = DateTime.TryParseExact(dateString, "MM/dd/yyyy", provider, DateTimeStyles.None, out var dateTime2);
            
        }
    }
}
