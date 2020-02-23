using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xunit;

namespace OutsideInTests
{
    public class ApplicationsControllerTests : ControllerTestsBase
    {
        [Fact]
        public async Task should_retrieve_application()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var applicationId = Guid.NewGuid();
            var response = await client.GetAsync($"/applications/{applicationId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task should_fail_without_valid_token()
        {
            var applicationId = Guid.NewGuid();
            var response = await client.GetAsync($"/applications/{applicationId}");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }
    }
}