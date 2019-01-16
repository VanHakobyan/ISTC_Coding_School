using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.AsyncAwait.AA_01
{
    class Program
    {
        // Three things to note in the signature:  
        //  - The method has an async modifier.   
        //  - The return type is Task or Task<T>. 
        //    Here, it is Task<string> because the return statement returns an string.  
        //  - The method name ends in "Async."  
        static async Task<string> AccessTheWebAsync()
        {
            // You need to add a reference to System.Net.Http to declare client.  
            HttpClient client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the  
            // task you'll get a string (urlContents).  
            Task<string> getStringTask = client.GetStringAsync("https://istc.am/");


            // The await operator suspends AccessTheWebAsync.  
            //  - AccessTheWebAsync can't continue until getStringTask is complete.  
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.  
            //  - Control resumes here when getStringTask is complete.   
            //  - The await operator then retrieves the string result from getStringTask.  
            string urlContents = await getStringTask;

            return urlContents;
        }
        static void Main(string[] args)
        {
            var content = AccessTheWebAsync().Result;
            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
