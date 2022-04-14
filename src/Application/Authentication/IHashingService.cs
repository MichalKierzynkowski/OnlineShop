namespace Application.Authentication;

public interface IHashingService
{
    string MakeHash(string value);
}