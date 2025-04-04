using GiftHub.ApplicationCore.Models;

namespace GiftHub.ApplicationCore.Interfaces
{
    public interface IJwtGenerator
    {
        string Generate(User user);
    }
}
