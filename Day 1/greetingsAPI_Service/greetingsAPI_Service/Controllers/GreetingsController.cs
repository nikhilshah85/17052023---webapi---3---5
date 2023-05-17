using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace greetingsAPI_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {

        [HttpGet]
        [Route("greetings")]
        public IActionResult Greetings()
        {
            return Ok("Hello and Welcome to WebAPI Development");
        }

        [HttpGet]
        [Route("greetme/{name}")]
        public IActionResult Greetings(string name)
        {
            return Ok("Hello " + name);
        }

        [HttpGet]
        [Route("calculate/{num1}/{num2}")]
        public IActionResult AddNumbers(int num1, int num2)
        {
            int add = num1 + num2;
            return Ok(add);
        }



    }
}
