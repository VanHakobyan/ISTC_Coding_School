using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISTC.FiveStage.Technology.Publish.Publish_01.Models;

namespace ISTC.FiveStage.Technology.Publish.Publish_01.Controllers
{
    public class HomeController : Controller
    {
        private static DateTime _dateTime = DateTime.Now;
        
        public IActionResult Index()
        {
            ViewBag.Date = _dateTime;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
