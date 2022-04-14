using Domain.Entities;
using Domain.Exceptions;

namespace Application.Authentication;

public class LoginService : ILoginService
{
    // todo: implement nice way
    // todo: throw authorization exception or other stuff
    public User Login(string username, string password)
    {
        throw new AuthenticationException();
        return new User("username", "password");
    }
}