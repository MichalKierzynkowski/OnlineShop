using Application.Authentication;
using Application.Authentication.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AuthenticationController : BaseApiController
{
    private readonly IJwtService _jwtService;

    public AuthenticationController(IJwtService jwtService)
    {
        _jwtService = jwtService;
    }
    
    [HttpPost]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var token = _jwtService.Login(loginRequest.Username, loginRequest.Password);
        var bearerToken = token.Token;

        return Ok(bearerToken);
    }

    [HttpGet]
    [Authorize]
    [Route("secret")]
    public IActionResult Secret()
    {
        return Ok("Secret message");
    }
    
    [HttpGet]
    [Route("not-secret")]
    public IActionResult NotSecret()
    {
        return Ok("You can see this message");
    }
    
    [HttpDelete]
    public IActionResult Logout()
    {
        // todo: add logout method
        return NoContent();
    }
}