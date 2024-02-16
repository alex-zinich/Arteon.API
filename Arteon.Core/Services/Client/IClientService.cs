using Arteon.Core.Entities;

namespace Arteon.Core.Services
{
    public interface IClientService
    {
        bool IsUserExist(string fullName, string email);
        Client GetClientByFullNameOrEmail(string fullName, string email);
        Client AddClient(string fullName, string email);
    }
}
