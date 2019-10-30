using ISTC.FiveStage.Technology.WebApi.API_00.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTC.FiveStage.Technology.WebApi.API_00
{
    public static class Factory
    {
        public static WeatherForecastExtended ToExtendedModel(WeatherForecast wf)
        {
            return new WeatherForecastExtended
            {
                Date = wf.Date,
                Summary = wf.Summary,
                TemperatureC = wf.TemperatureF,
                CreationTime = DateTime.UtcNow
            };
        }

        public static WeatherForecastResponseModel ToResponseModel(WeatherForecastExtended wf)
        {
            return new WeatherForecastResponseModel
            {
                Summary = wf.Summary,
                CreationTime = wf.CreationTime
            };
        }
    }
}
