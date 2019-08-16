using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.WorkWithText.GetContent
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(@"https://github.com/vanhakobyan");
            File.AppendAllText(@"E:\content.html", content);
        }
    }
}
