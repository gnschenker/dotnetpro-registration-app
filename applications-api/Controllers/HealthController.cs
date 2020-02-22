using Microsoft.AspNetCore.Mvc;

namespace Applications.Controllers
{
  [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public bool Get() { return true; }
    }
}
