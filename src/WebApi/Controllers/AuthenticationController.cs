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
        var tokenDto = new Token(token.Token);

        return Ok(tokenDto);
    }

    [HttpGet]
    [Authorize]
    [Route("secret")]
    public IActionResult Secret()
    {
        return Ok(new TestMessage() {Text = "Secret Message"});
    }

    [HttpGet]
    [Route("not-secret")]
    public IActionResult NotSecret()
    {
        return Ok(new TestMessage() {Text = " You can see this message"});
    }

    [HttpDelete]
    public IActionResult Logout()
    {
        // todo: add logout method
        return NoContent();
    }

    // todo: remove some time
    public class TestMessage
    {
        public string Text { get; set; }
    }

    // todo: move and refactor
    public class Token
    {
        public string Value { get; set; }
        public string SwaggerValue { get; set; }

        public Token(string token)
        {
            Value = token;
            SwaggerValue = "Bearer " + token;
        }
    }
}