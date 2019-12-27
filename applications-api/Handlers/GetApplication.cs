using System;
using MediatR;
using Applications.Model;

namespace Applications.Handlers
{
    public class GetApplication : IRequest<Application>
    {
        public Guid ApplicationId { get; }

        public GetApplication(Guid applicationId)
        {
            ApplicationId = applicationId;
        }
    }
}