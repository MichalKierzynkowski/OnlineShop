using Microsoft.Extensions.DependencyInjection;

namespace Application.Authentication.Jwt;

public static class JwtServiceProvider
{
    public static void AddJwt(this IServiceCollection services)
    {
        services.AddTransient<JwtFactory>();
        services.AddTransient<IJwtService, JwtService>();

        services.AddTransient<ILoginService, LoginService>();
        services.AddTransient<IHashingService, HashingService>();
    }
}