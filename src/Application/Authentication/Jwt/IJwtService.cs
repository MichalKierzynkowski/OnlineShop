namespace Application.Authentication.Jwt;

public interface IJwtService
{
    JwtToken Login(string username, string password);
}