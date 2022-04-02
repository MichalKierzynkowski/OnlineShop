using System.Text;
using Application.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace WebApi.Authentication;

public static class UseJwt
{
    public static void AddJwt(this IServiceCollection services)
    {
        services.AddTransient<JwtFactory>();
        
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SuperDuperLongPasswordlalalalala")),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false
            };
        });
    }
}