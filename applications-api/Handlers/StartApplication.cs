using Applications.Model;
using NServiceBus;
using System;
using System.Threading.Tasks;

namespace applications_api.Handlers
{
    public class StartApplication : ICommand
    {
        public Guid ApplicationId { get; set; }
        public string Form { get; set; }
    }

    public class StartApplicationHandler : IHandleMessages<StartApplication>
    {
        private readonly ApplicationContext dbContex;

        public StartApplicationHandler(ApplicationContext dbContex)
        {
            this.dbContex = dbContex;
        }

        public async Task Handle(StartApplication message, IMessageHandlerContext context)
        {
            dbContex.Applications.Add(new Application
            {
                ApplicationId = message.ApplicationId,
                Form = message.Form,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now
            });
            await dbContex.SaveChangesAsync();
        }
    }
}
