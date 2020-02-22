using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace OutsideInTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task when_loading_application()
        {
            var url = $"http://api:5000/applications/{Guid.NewGuid()}";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
