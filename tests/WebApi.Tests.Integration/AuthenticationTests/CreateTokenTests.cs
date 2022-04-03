using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace WebApi.Tests.Integration.AuthenticationTests;

[Collection("HTTP Fixture")]
public class CreateTokenTests
{
    private readonly HttpFixture _httpFixture;

    public CreateTokenTests(HttpFixture httpFixture)
    {
        _httpFixture = httpFixture;
    }

    [Fact]
    public async Task Services_Null_SoFar()
    {
        // _httpFixture.Services.Should().BeNull();
        var client = _httpFixture.Client;

        var response = await client.GetAsync("api/Authentication/not-secret");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        
        var response2 = await client.GetAsync("api/Authentication/secret");

        response2.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }
}