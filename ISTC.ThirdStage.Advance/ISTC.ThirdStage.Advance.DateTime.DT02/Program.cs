using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.DateTime.DT02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current culture name  
            string currentCulture = Thread.CurrentThread.CurrentCulture.DisplayName;
            var invariantCulture = CultureInfo.InvariantCulture;
            System.DateTime currentTime = System.DateTime.Now; //"1/9/2016 10:22:45 AM"  
            //// Getting DateTime based on culture.  
            string dateInUSA = currentTime.ToString("D", new CultureInfo("en-US")); // USA - Saturday, January 09, 2016  
            string dateInHindi = currentTime.ToString("D", new CultureInfo("hi-IN")); // Hindi - 09 ????? 2016  
            string dateInJapan = currentTime.ToString("D", new CultureInfo("ja-JP")); // Japan - 2016?1?9?  
            string dateInFrench = currentTime.ToString("D", new CultureInfo("fr-FR")); // French - samedi 9 janvier 2016  

            string dateInOriya = currentTime.ToString("D", new CultureInfo("or")); // Oriya - 09 ???????? 2016  
            // Convert Hindi Date to French Date  
            System.DateTime originalResult = new System.DateTime(2016, 01, 09);
            // Converting Hindi Date to DateTime object  
            bool success = System.DateTime.TryParse(dateInHindi, new System.Globalization.CultureInfo("hi-IN"),
                System.Globalization.DateTimeStyles.None, out originalResult);

            // Next convert current date to French date  
            string frenchTDate = originalResult.ToString("D", new CultureInfo("fr-FR")); // French - samedi 9 janvier 2016  

            // To get DatePattern from Culture  
            CultureInfo fr = new CultureInfo("fr-FR");
            string shortUsDateFormatString = fr.DateTimeFormat.LongDatePattern;
            string shortUsTimeFormatString = fr.DateTimeFormat.ShortTimePattern;

            // To get all installed culture in .Net version  
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.WriteLine(ci.Name + ", " + ci.EnglishName);
            }

        }
    }
}
