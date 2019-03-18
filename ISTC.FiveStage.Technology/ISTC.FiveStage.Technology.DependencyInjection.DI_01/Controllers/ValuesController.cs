using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("GetUrl")]
        public IActionResult GetUrl()
        {
            var url = _configuration.GetSection("URL").Value;
            return Ok(url);
        }

        [Route("GetUserDetails")]
        public IActionResult GetUserDetails()
        {
            var details = _configuration.GetSection("UserDetails").GetChildren().Select(x => new { x.Key, x.Value });
            return Ok(details);
        }
    }
}
