using System.Text;
using Application.Authentication;
using Application.Authentication.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace WebApi.Authentication;

public static class UseJwt
{
    public static void AddWebJwt(this IServiceCollection services)
    {
        services.AddJwt();
        
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