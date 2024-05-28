using System.Net;
using Xunit.Abstractions;

namespace Integration.Tests.Tests
{
    public class ResourcesTest
    {
        [Theory]
        [InlineData("vue")]
        [InlineData("svelte")]
        public async Task GetWebResourceRootReturnsOkStatusCode(string resource)
        {
            // Arrange
            var appHost = await DistributedApplicationTestingBuilder.CreateAsync<Projects.SvelteKit_Aspire_AppHost>();
            await using var app = await appHost.BuildAsync();
            await app.StartAsync();

            // Act
            var httpClient = app.CreateHttpClient(resource);
            var response = await httpClient.GetAsync("/");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}