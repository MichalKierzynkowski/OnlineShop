namespace Application.Authentication.Jwt;

public class JwtToken
{
    public string Token { get; }
    public DateTime ValidTo { get; }

    public JwtToken(string token, DateTime validTo)
    {
        Token = token;
        ValidTo = validTo;
    }
}