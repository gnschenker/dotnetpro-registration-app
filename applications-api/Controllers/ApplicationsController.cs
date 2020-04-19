using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Applications.Model;
using Applications.Handlers;
using Microsoft.AspNetCore.Authorization;
using NServiceBus;
using applications_api.Handlers;
using System.Collections.Generic;

namespace Applications.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class ApplicationsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMessageSession messageSession;

        public ApplicationsController(IMediator mediator, IMessageSession messageSession)
        {
            this.mediator = mediator;
            this.messageSession = messageSession;
        }

        [HttpGet]
        public async Task<IEnumerable<Application>> Get()
        {
            var applications = await mediator.Send(new GetApplications());
            return applications;
        }

        [HttpGet("{applicationId}")]
        public async Task<Application> Get(Guid applicationId)
        {
            var application = await mediator.Send(new GetApplication(applicationId));
            return application;
        }

        [HttpPost]
        public async Task Post([FromBody]NewApplication newApplication)
        {
            var command = new StartApplication
            {
                ApplicationId = newApplication.ApplicationId,
                Form = newApplication.Form
            };
            await messageSession.SendLocal(command)
                .ConfigureAwait(false);
        }

        public class NewApplication
        {
            public Guid ApplicationId { get; set; }
            public string Form { get; set; }
        }
    }
}
