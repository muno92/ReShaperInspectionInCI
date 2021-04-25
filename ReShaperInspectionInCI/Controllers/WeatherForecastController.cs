using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ReShaperInspectionInCI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            new Random();
            return Enumerable.Range(1, 5).Select(_ => new WeatherForecast())
                .ToArray();
        }
    }
}
