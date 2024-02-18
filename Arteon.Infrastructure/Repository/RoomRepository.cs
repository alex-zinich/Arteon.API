using Arteon.Core.Entities;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Infrastructure.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly IHotelContext _context;

        public RoomRepository(IHotelContext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetRooms()
        {
            return _context.Rooms.AsNoTracking()
                .Include(x => x.Bookings)
                .Include(x => x.RoomType)
                .ToList();
        }

        public Room GetById(Guid id)
        {
            return _context.Rooms.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}
