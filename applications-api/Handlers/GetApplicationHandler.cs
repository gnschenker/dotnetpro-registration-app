
using System.Threading;
using System.Threading.Tasks;
using Applications.Model;
using MediatR;

namespace Applications.Handlers
{
    public class GetApplicationHandler : IRequestHandler<GetApplication, Application>
    {
        public Task<Application> Handle(GetApplication request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Application{
                ApplicationId = request.ApplicationId
            });
        }
    }
}