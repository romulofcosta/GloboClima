using Microsoft.AspNetCore.Mvc;

namespace GloboClima.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AuthController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}
