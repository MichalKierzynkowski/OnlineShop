using Domain.Entities;

namespace Application.Authentication;

public class LoginService : ILoginService
{
    // todo: implement nice way
    // todo: throw authorization exception or other stuff
    public User Login(string username, string password)
    {
        return new User("username", "password");
    }
}