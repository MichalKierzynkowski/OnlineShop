using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Application.Authentication;
using FluentAssertions;
using Xunit;

namespace WebApi.Tests.Integration.AuthenticationTests;

[Collection("HTTP Fixture")]
public class CreateTokenTests
{
    private readonly HttpClient _client;

    public CreateTokenTests(HttpFixture httpFixture)
    {
        _client = httpFixture.Client;
    }

    [Fact]
    public async Task LoginSuccess_TokenNotNullNorEmpty()
    {
        var loginRequest = new LoginRequest()
        {
            Username = "username",
            Password = "password"
        };
        
        var c = JsonContent.Create(loginRequest);
        
        var response = await _client.PostAsync("api/authentication", c);
        var token = await response.Content.ReadAsStringAsync();
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        token.Should().NotBeNullOrWhiteSpace();
    }
}