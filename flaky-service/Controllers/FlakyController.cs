using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace some_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlakyController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly Random rnd = new Random((int)DateTime.Now.Ticks);
        public FlakyController(ILogger<FlakyController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            if (rnd.Next(10) < 5)
            {
                var msg = "Simulating a problem...";
                logger.LogWarning(msg);
                throw new InvalidOperationException(msg);
            }
            return "Hello world!";
        }
    }
}
