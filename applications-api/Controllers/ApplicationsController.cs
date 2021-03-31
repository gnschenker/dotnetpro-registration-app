using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Applications.Model;
using Applications.Handlers;

namespace Applications.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ApplicationsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{applicationId}")]
        public async Task<Application> Get(Guid applicationId)
        {
            var application = await mediator.Send<Application>(new GetApplication(applicationId));
            return application;
        }
    }
}
