using System;
using System.Threading;
using System.Threading.Tasks;
using Applications.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Applications.Handlers
{
    public class GetApplicationHandler : IRequestHandler<GetApplication, Application>
    {
        private readonly ApplicationContext context;

        public GetApplicationHandler(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<Application> Handle(GetApplication request,
            CancellationToken cancellationToken)
        {
            return await context.Applications
                .SingleOrDefaultAsync(a => a.ApplicationId == request.ApplicationId);
        }
    }

    public class GetApplication : IRequest<Application>
    {
        public Guid ApplicationId { get; }

        public GetApplication(Guid applicationId)
        {
            ApplicationId = applicationId;
        }
    }
}