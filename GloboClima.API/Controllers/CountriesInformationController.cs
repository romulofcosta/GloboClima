using Microsoft.AspNetCore.Mvc;

namespace GloboClima.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CountriesInformationController : Controller
    {
        public CountriesInformationController() { }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
