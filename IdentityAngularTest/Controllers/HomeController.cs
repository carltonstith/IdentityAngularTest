using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace IdentityAngularTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        //[Authorize]
        public IActionResult Get()
        {
            return Ok("This works");
        }
    }
}
