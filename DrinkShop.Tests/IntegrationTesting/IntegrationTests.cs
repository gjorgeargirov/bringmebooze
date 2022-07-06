using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;


namespace DrinkShop.Tests.IntegrationTesting
{
    public class IntegrationTests : IntegrationTestBase
    {
        public IntegrationTests(MediaGalleryFactory<FakeStartup> factory) : base(factory)
        {

        }

        [Theory]
        [InlineData("/Products/Index")]
        public async Task AuthorizedMethod_UnauthenticatedUser_RedirectsToLogin(string url)
        {
            // Arrange
            var client = GetFactory().CreateClient(
                new WebApplicationFactoryClientOptions
                {
                    AllowAutoRedirect = false
                }
            );

            // Act
            var response = await client.GetAsync(url);

            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
            Assert.StartsWith("http://localhost/Account/Login", response.Headers.Location.OriginalString);
        }

    }
}
