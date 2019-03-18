using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISTC.FiveStage.Technology.DependencyInjection.DI_01.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IFirstService _iFirstService;
        public HelloController(IFirstService firstService)
        {
            _iFirstService = firstService;
        }

        [HttpGet,Route("SayHello")]
        public IActionResult SayHello()
        {
            var welcomeIstc = _iFirstService.WelcomeISTC();
            return Ok(welcomeIstc);
        }
    }

}