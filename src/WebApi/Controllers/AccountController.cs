using Application.Dto.User;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Controllers;

public class AccountController : BaseApiController
{
    private readonly IUserService _userService;

    public AccountController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost]
    [SwaggerOperation(Summary = "Create new account")]
    public IActionResult Create(CreateUserDto createUserDto)
    {
        try
        {
            var userId = _userService.Create(createUserDto);
            
            // todo: change to Created when GET endpoint is ready
            return Ok(userId);
        }
        catch (ArgumentException e)
        {
            // todo: check if there is better http code for that
            return Conflict(e.Message);
        }
    }
}