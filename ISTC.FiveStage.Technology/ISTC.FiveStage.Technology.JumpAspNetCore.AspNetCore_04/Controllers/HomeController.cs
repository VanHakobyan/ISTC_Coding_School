using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISTC.FiveStage.Technology.JumpAspNetCore.AspNetCore_04.Models;

namespace ISTC.FiveStage.Technology.JumpAspNetCore.AspNetCore_04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ISTC = "ISTC C#";
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

        public IActionResult Apri()
        {
            ViewBag.Apri = "Apri Anin";
            return View();
        }
    }
}
