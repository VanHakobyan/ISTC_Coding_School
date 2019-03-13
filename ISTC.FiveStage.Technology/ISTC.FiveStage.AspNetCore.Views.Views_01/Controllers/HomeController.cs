using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ISTC.FiveStage.AspNetCore.Views.Views_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace ISTC.FiveStage.AspNetCore.Views.Views_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "ISTC C# Template !!!";
            ViewData["Cover"] = "ISTC C# course schedule";
            var info = new ISTC_info
            {
                Day = $"{(DateTime.Parse("2019-04-01") - DateTime.Now).Days} days left",
                Name = "ISTC",
                Url = @"http://istc.am"
            };
            return View(info);
        }

        public IActionResult Course()
        {
            return View();
        }

        public IActionResult About()
        {
            var ids = Enumerable.Range(0, 10).ToList();
            ViewData["ids"] = ids;
            return View();
        }

        public IActionResult NewV()
        {
            return View();
        }
    }
}
