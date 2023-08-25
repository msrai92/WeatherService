using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WeatherService.Entities;

namespace WeatherService.Controllers
{
    [ApiController]
    [Route("weather")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOptions<AppSettings> _appSettings;

        private static readonly Dictionary<int, string> Summaries = new Dictionary<int, string>(){{0,
            "Freezing" }, {4,"Bracing" }, {10,"Chilly" } , {16,"Cool" }, {21,"Mild" }, {27,"Warm" }, {32,"Hot" }, {38,"Sweltering" }, {43,"Scorching" }
        };

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<AppSettings> options)
        {
            _logger = logger;
            _appSettings = options;
        }

        [HttpGet(Name = "GetForecast")]
        public WeatherForecast Get(int postalCode)
        {
            
            WeatherForecast forecast = WeatherService.Implementations.WeatherForecastImplementation.GetWeatherForecast(_appSettings.Value.url, _appSettings.Value.key, postalCode, Summaries).Result;

            //todo: set Summary value on forecast response using Summaries data dictionary
            
            return forecast;
        }
    }
}