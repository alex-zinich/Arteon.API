using Arteon.Core.Entities;

namespace Arteon.Core.Services.Database
{
    public interface IClientRepository
    {
        Client GetClientByEmail(string email);
        Client GetClientByFullName(string fullName);
        Client AddClient(Client client);
    }
}
