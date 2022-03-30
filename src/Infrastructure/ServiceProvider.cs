using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceProvider
    {
        public static void RegisterTestInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<OnlineShopDbContext>(opt => opt.UseInMemoryDatabase(nameof(OnlineShopDbContext)));

            services.RegisterRepositories();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
