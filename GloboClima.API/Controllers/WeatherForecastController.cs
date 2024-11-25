using GloboClima.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GloboClima.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string city)
        {
            try
            {
                var res = await _weatherForecastService.GetCityWeatherForecast(city);

                if (res.Contains("\"cod\":\"404\""))
                    return NotFound(res);

                return Ok(res);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
