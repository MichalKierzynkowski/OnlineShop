using Application.Authentication;
using Application.Authentication.Jwt;
using Domain.Entities;
using FluentAssertions;
using Xunit;

namespace Application.Tests.Unit.Authentication;

public class JwtFactoryTests
{
    private readonly JwtFactory _factory;

    public JwtFactoryTests()
    {
        this._factory = new JwtFactory();
    }
    
    [Fact]
    public void CreateAccessToken_TokenShouldNotBeNullOrWhitespace()
    {
        var user = new User("user", "qwerty");

        string token = _factory.CreateAccessToken(user).Token;
        
        token.Should().NotBeNullOrWhiteSpace();
    }
}