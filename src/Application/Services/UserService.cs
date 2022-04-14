using Application.Dto.User;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IRepository<Guid, User> _userRepository;

    public UserService(IRepository<Guid, User> userRepository)
    {
        _userRepository = userRepository;
    }
    
    public Guid Create(CreateUserDto createUser)
    {
        if(_userRepository.Get().Any(x => x.Login.Equals(createUser.Username, StringComparison.InvariantCultureIgnoreCase)))
        {
            // todo: introduce custom exception type?
            throw new ArgumentException("User already exists");
        }

        var user = new User(createUser.Username, createUser.Password);

        user = _userRepository.Add(user);

        return user.Id;
    }
}