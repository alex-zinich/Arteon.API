using Arteon.Core.Entities;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Infrastructure.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly IHotelContext _context;

        public ServiceRepository(IHotelContext context)
        {
            _context = context;
        }

        public IEnumerable<Service> GetAll()
        {
            return _context.Services.AsNoTracking().ToList();
        }
    }
}
