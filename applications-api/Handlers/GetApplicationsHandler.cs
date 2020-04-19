using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Applications.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Applications.Handlers
{
    public class GetApplicationsHandler : IRequestHandler<GetApplications, IEnumerable<Application>>
    {
        private readonly ApplicationContext context;

        public GetApplicationsHandler(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Application>> Handle(GetApplications request, 
            CancellationToken cancellationToken)
        {
            return await context.Applications.ToListAsync();
        }
    }

    public class GetApplications : IRequest<IEnumerable<Application>>
    {
    }
}