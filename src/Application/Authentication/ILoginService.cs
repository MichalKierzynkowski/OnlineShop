using Domain.Entities;

namespace Application.Authentication;

public interface ILoginService
{
    User Login(string username, string password);
}