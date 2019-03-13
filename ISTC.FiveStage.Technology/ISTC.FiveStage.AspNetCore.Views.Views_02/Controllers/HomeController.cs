using Microsoft.AspNetCore.Mvc;
using ISTC.FiveStage.AspNetCore.Views.Views_02.Models;

namespace ISTC.FiveStage.AspNetCore.Views.Views_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IActionResult Contact()
        {
            var people = GetPeople();
            var contactViewModel = GetView();
            ViewData["ContactViewModel"] = contactViewModel;
            return View(people);
        }

        [NonAction]
        public ContactViewModel GetView()
        {
            return new ContactViewModel
            {
                FirstName = "Vanik",
                LastName = "Hakobyan",
                Github = "https://github.com/VanHakobyan",
                Linkedin = "https://www.linkedin.com/in/vanikhakobyan/"
            };
        }

        [NonAction]
        public People GetPeople()
        {
            return new People() { Address = "Aleq Manukyan", Name = "ISTC", Age = 4 };
        }
    }
}
