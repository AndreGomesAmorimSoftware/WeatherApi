using Microsoft.AspNetCore.Mvc;
using WeatherApi.Interfaces;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(string city, string country)
        {
            var weather = await _weatherService.GetTemperaturesAsync(city, country);

            return weather != null ? Ok(weather) : BadRequest();
        }
    }
}
