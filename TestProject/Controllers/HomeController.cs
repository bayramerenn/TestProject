using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet("testas")]
        public IActionResult Test()
        {
            return Ok();
        }

        [HttpGet("testa")]
        public IActionResult Testa()
        {
            return Ok();
        }

        [HttpGet("testaa")]
        public IActionResult Testaa()
        {
            return Ok();
        }

        [HttpGet("testaaasd")]
        public IActionResult Testaaasd()
        {
            return Ok();
        }

        [HttpGet("MesutCancik2")]
        public IActionResult MesutCancik()
        {
            return Ok();
        }
    }
}
