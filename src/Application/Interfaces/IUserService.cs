using Application.Dto.User;

namespace Application.Interfaces;

public interface IUserService
{
    Guid Create(CreateUserDto createUser);
    IEnumerable<UserDto> Get();
}