using Xunit;

namespace WebApi.Tests.Integration;

[CollectionDefinition("HTTP Fixture")]
public class HttpCollection : IClassFixture<HttpFixture>
{
    
}