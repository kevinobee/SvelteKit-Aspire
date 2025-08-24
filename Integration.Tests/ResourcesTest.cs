using System.Net;

namespace Integration.Tests
{
    public class ResourcesTest
    {
        [Theory]
        [InlineData("vue")]
        [InlineData("svelte")]
        public async Task GetWebResourceRootReturnsOkStatusCode(string resource)
        {
            // Arrange
            var appHost = await DistributedApplicationTestingBuilder.CreateAsync<Projects.SvelteKit_Aspire_AppHost>(TestContext.Current.CancellationToken);
            await using var app = await appHost.BuildAsync(TestContext.Current.CancellationToken);
            await app.StartAsync(TestContext.Current.CancellationToken);

            // Act
            var httpClient = app.CreateHttpClient(resource);
            var response = await httpClient.GetAsync("/", TestContext.Current.CancellationToken);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}