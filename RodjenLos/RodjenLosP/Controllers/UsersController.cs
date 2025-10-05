using Microsoft.AspNetCore.Mvc;

namespace RodjenLosP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Dje se kupas");
        }
    }
}
