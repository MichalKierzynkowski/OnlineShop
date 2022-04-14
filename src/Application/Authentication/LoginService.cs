using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;

namespace Application.Authentication;

public class LoginService : ILoginService
{
    private readonly IHashingService _hashingService;
    private readonly IRepository<Guid, User> _userRepository;

    public LoginService(IHashingService hashingService, IRepository<Guid, User> userRepository)
    {
        _hashingService = hashingService;
        _userRepository = userRepository;
    }
    
    public User Login(string username, string password)
    {
        var user = _userRepository.Get().FirstOrDefault(x => x.Login.Equals(username, StringComparison.InvariantCultureIgnoreCase));
        if (user is not null)
        {
            string hash = _hashingService.MakeHash(password);

            if (hash == user.Password)
            {
                return user;
            }
        }
        
        throw new AuthenticationException();
    }
}