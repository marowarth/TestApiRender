using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApiRender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarowarthController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from MarowarthController!";
        }
    }
}
