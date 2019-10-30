using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISTC.FiveStage.Technology.WebApi.API_00.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ISTC.FiveStage.Technology.WebApi.API_00.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecastExtended> weatherForecasts = new List<WeatherForecastExtended>();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("weather")]
        public async Task<IActionResult> Weather(int first, int second = 5)
        {
            var rng = new Random();
            var r = Enumerable.Range(first, second).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            return Ok(await Task.FromResult(r));
        }

        [HttpPost, Route("Insert")]
        public async Task<IActionResult> AddData([FromBody]WeatherForecast forecast)
        {
            try
            {
                WeatherForecastExtended weatherForecastExtendedModel = Factory.ToExtendedModel(forecast);
                weatherForecasts.Add(weatherForecastExtendedModel);
                if (weatherForecasts.Count > 10) return Redirect("Cleanup");
                return Ok(await Task.FromResult(Factory.ToResponseModel(weatherForecastExtendedModel)));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet, Route("Cleanup")]
        public async Task<IActionResult> Cleanup()
        {
            int count = weatherForecasts.Count;
            if (count > 10)
            {
                weatherForecasts.Clear();
                return Ok($"Cleanup success!!! Item count=={count}");
            }
            else
            {
                return Ok(await Task.FromResult($"All ok!! item count={count}"));
            }
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromQuery]int index, [FromBody] WeatherForecast weather)
        {
            var ex = Factory.ToExtendedModel(weather);
            if (weatherForecasts.Count > index)
            {
                weatherForecasts[index] = ex;
            }
            return Ok(await Task.FromResult(Factory.ToResponseModel(ex)));
        }

        [HttpDelete, Route("Remove")]
        public async Task<IActionResult> Delete([FromBody] List<WeatherForecast> weathers)
        {
            IEnumerable<WeatherForecastExtended> weatherForecastExtendeds = weathers.Select(x => Factory.ToExtendedModel(x));

            foreach (var weather in weatherForecastExtendeds)
            {
                weatherForecasts.Remove(weatherForecasts.FirstOrDefault(x => x.Summary == weather.Summary));
            }
            return Ok(await Task.FromResult(weatherForecastExtendeds.Select(x => Factory.ToResponseModel(x))));
        }

        [HttpGet, Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(await Task.FromResult(weatherForecasts));
        }

    }
}
