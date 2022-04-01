using Application.Factories;
using Application.Interfaces;
using Application.Mappings;
using Application.Services;
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
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService,CategoryService>();
        }
    }
}