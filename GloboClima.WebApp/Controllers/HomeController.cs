using GloboClima.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace GloboClima.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string city)
        {

            ForecastModel? jsonForecast = null;

            if (city != null)
            {
                var endpoint = $"https://localhost:44376/WeatherForecast/?City={city}";

                var res = await new HttpClient().GetAsync(endpoint);

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await res.Content.ReadAsStringAsync();
                    jsonForecast = JsonSerializer.Deserialize<ForecastModel>(content);
                }
            }

             return View(jsonForecast);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
