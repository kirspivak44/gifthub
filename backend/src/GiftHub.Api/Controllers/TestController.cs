using Microsoft.AspNetCore.Mvc;

namespace GiftHub.Api.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld()
        {
            return Ok("Hello World");
        }
    }
}
