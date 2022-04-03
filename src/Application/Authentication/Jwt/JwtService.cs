namespace Application.Authentication.Jwt;

public class JwtService : IJwtService
{
    private readonly ILoginService _loginService;
    private readonly JwtFactory _jwtFactory;

    public JwtService(ILoginService loginService, JwtFactory jwtFactory)
    {
        _loginService = loginService;
        _jwtFactory = jwtFactory;
    }
    
    public JwtToken Login(string username, string password)
    {
        var user = _loginService.Login(username, password);

        var token = _jwtFactory.CreateAccessToken(user);

        return token;
    }
}