using Microsoft.AspNetCore.Mvc;

namespace MySwaggerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return Ok(new { Message = "Hello, World!" });
        }

        [HttpPost("echo")]
        public IActionResult Echo([FromBody] string input)
        {
            return Ok(new { Echo = input });
        }
    }
}
