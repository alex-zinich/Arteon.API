using Arteon.Core.Entities;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Infrastructure.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly IHotelContext _context;

        public ClientRepository(IHotelContext context)
        {
            _context = context;
        }

        public Client GetClientByEmail(string email)
        {
            return _context.Clients.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }

        public Client GetClientByFullName(string fullName)
        {
            return _context.Clients.AsNoTracking().FirstOrDefault(c => c.FullName == fullName);
        }

        public Client AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();

            return client;
        }
    }
}
