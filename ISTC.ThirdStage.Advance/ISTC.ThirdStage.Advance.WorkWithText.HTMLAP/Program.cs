using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ISTC.ThirdStage.Advance.WorkWithText.HTMLAP
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlDocument document = new HtmlDocument();
            string text = File.ReadAllText(@"E:\content.html");
            //Console.WriteLine(text);
            document.LoadHtml(text);

            HtmlNode selectSingleNode = document.DocumentNode.SelectSingleNode("//*[@id=\"js-repo-pjax-container\"]/div[1]/div/h1/span[1]/a");
            string innerText = selectSingleNode.InnerText;
          
            Console.WriteLine(innerText);
            Console.ReadKey();
        }
    }
}
