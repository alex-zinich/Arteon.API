using Arteon.Core.Entities;
using Arteon.Core.Services.Database;

namespace Arteon.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool IsUserExist(string fullName, string email)
        {
            return _clientRepository.GetClientByFullName(fullName) != null || _clientRepository.GetClientByEmail(email) != null;
        }

        public Client GetClientByFullNameOrEmail(string fullName, string email)
        {
            return _clientRepository.GetClientByFullName(fullName) ?? _clientRepository.GetClientByEmail(email);
        }

        public Client AddClient(string fullName, string email)
        {
            return _clientRepository.AddClient(new Client(fullName, email));
        }
    }
}
