using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Applications.Handlers;

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
            var sut = new GetApplicationHandler();

            // Act
            var response = await sut.Handle(new GetApplication(applicationId), token);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(applicationId, response.ApplicationId);
        }
    }
}
