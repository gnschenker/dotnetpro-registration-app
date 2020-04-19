using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Applications.Handlers;
using Applications.Model;
using Microsoft.EntityFrameworkCore;

namespace unittests
{
    public class UnitTest1
    {
        [Fact]
        public async Task should_return_application()
        {
            // Arrange
            var token = new CancellationToken();
            var applicationId = Guid.NewGuid();
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase("TestDB")
                .Options;
            var context = new ApplicationContext(options);
            context.Applications.Add(new Application { ApplicationId = applicationId });
            context.SaveChanges();
            var sut = new GetApplicationHandler(context);

            // Act
            var response = await sut.Handle(new GetApplication(applicationId), token);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(applicationId, response.ApplicationId);
        }
    }
}
