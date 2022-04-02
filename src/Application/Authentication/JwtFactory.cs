using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Application.Authentication;

public class JwtFactory
{
    // todo: introduce jwt settings
    public string CreateAccessToken(User user)
    {
        var now = DateTime.UtcNow;
        
        var notBefore = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        var expiration = new DateTimeOffset(DateTime.UtcNow.AddMinutes(15)).ToUnixTimeSeconds().ToString();

        var claims = new Claim[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Login),
            new Claim(JwtRegisteredClaimNames.Nbf, notBefore),
            new Claim(JwtRegisteredClaimNames.Exp, expiration),
            new Claim(ClaimTypes.Role, "User"),
            new Claim(ClaimTypes.Role, "Admin"),
            
            new Claim(nameof(JwtEnum.UserId), user.Id.ToString()),
        };
        
        var jwtKey = Encoding.UTF8.GetBytes("SuperDuperLongPasswordlalalalala");
        var symmetricSecurityKey = new SymmetricSecurityKey(jwtKey);
        var jwtSecurityAlgorithm = SecurityAlgorithms.HmacSha256;
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, jwtSecurityAlgorithm);
        
        var jwt = new JwtSecurityToken(
            new JwtHeader(signingCredentials),
            new JwtPayload(claims));
        
        var token = new JwtSecurityTokenHandler().WriteToken(jwt);

        return token;
    }
}