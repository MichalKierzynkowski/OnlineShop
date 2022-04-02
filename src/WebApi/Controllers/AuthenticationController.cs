using Application.Authentication;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AuthenticationController : BaseApiController
{
    private readonly JwtFactory jwtFactory;

    public AuthenticationController(JwtFactory jwtFactory)
    {
        this.jwtFactory = jwtFactory;
    }
    
    [HttpPost]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var user = new User(loginRequest.Username, loginRequest.Password);
        string token = "Bearer " + jwtFactory.CreateAccessToken(user);
        
        return Ok(token);
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
}