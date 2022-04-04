using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;

namespace WebApi.Tests.Integration;

public class HttpFixture : IDisposable
{
  private TestServer Server { get; }
  public IServiceProvider Services { get; }
  public HttpClient Client { get; }

    public HttpFixture()
    {
      var builder = new WebHostBuilder()
        .UseEnvironment("Development")
        .UseStartup<Startup>()
        .ConfigureAppConfiguration((hosting, config) => config.AddJsonFile("appsettings.json"));

      Server = new TestServer(builder);
      
      Services = Server.Services;
      Client = Server.CreateClient();
    }

  
    public void Dispose()
    {
      Client?.Dispose();
      Server?.Dispose();
    }
}