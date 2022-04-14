using Application.Authentication;
using Application.Authentication.Jwt;
using Application.Dto.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Controllers;

public class AuthenticationController : BaseApiController
{
    private readonly IJwtService _jwtService;

    public AuthenticationController(IJwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Log in and obtain access token")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var token = _jwtService.Login(loginRequest.Username, loginRequest.Password);
        JwtTokenDto tokenDto = new JwtSwaggerTokenDto(token.Token);

        return Ok(tokenDto);
    }

    [HttpGet]
    [Authorize]
    [SwaggerOperation(Summary = "Get sample restricted message")]
    [Route("secret")]
    public IActionResult Secret()
    {
        return Ok(new TestMessage() {Text = "Secret Message"});
    }

    [HttpGet]
    [Route("not-secret")]
    [SwaggerOperation(Summary = "Get sample not restricted message")]
    public IActionResult NotSecret()
    {
        return Ok(new TestMessage() {Text = " You can see this message"});
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Logout")]
    public IActionResult Logout()
    {
        // todo: add logout method
        return NoContent();
    }

    public class TestMessage
    {
        public string Text { get; set; }
    }
}