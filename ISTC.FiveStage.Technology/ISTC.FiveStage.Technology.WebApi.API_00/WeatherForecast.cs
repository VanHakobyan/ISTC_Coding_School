using System;
using System.ComponentModel.DataAnnotations;

namespace ISTC.FiveStage.Technology.WebApi.API_00
{
    public class WeatherForecast
    {
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }


        [DataType(DataType.PostalCode)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
