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
    public void Services_Null_SoFar()
    {
        _httpFixture.Services.Should().BeNull();
    }
}