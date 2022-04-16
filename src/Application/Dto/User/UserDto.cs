namespace Application.Dto.User;

public class UserDto
{
    public string Username { get; set; }

    public static UserDto FromUser(Domain.Entities.User user)
    {
        return new UserDto()
        {
            Username = user.Login
        };
    }
}