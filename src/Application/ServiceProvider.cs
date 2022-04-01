using Application.Factories;
using Application.Mappings;
using Domain.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
  public static class ServiceProvider
  {
    public static void RegisterApplication(this IServiceCollection services)
    {
      services.RegisterAutomapper();
      services.AddTransient<IProductFactory, ProductFactory>();
    }
  }
}