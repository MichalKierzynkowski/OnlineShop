using System;
using Xunit;

namespace WebApi.Tests.Integration;

public class HttpFixture : IDisposable
{
    public IServiceProvider Services { get; }

    public HttpFixture()
    {
        
    }
    
    public void Dispose()
    {
        
    }
}