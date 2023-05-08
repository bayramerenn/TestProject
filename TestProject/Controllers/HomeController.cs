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

        [HttpGet("aasdaaasd")]
        public IActionResult Test()
        {
            return Ok();
        }

        [HttpGet("testajjaqda")]
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

        [HttpGet("MesutCancik23")]
        public IActionResult MesutCancik()
        {
            return Ok();
        }
    }
}
