using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandlingAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        [Route("ThrowError")]
        public IActionResult ThrowError()
        {
            throw new Exception("Something went wrong!");
        }

    }
}