using System.Security.Cryptography;
using System.Text;

namespace Application.Authentication;

public class HashingService : IHashingService
{
    public string MakeHash(string value)
    {
        using SHA256 sha256 = SHA256.Create();

        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));

        string hash = Encoding.UTF8.GetString(bytes);

        return hash;
    }
}