using Arteon.Core.Entities;
using Arteon.Core.Models;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IHotelContext _hotelContext;

        public RoomService(IHotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public IEnumerable<Room> Filter(RoomFilterParameters parameters)
        {
            IQueryable<Room> roomQuery = _hotelContext.Rooms
                .AsNoTracking()
                .Include(x => x.Bookings)
                .Include(x => x.RoomType);

            if (parameters.StartDate != null && parameters.EndDate != null)
            {
                roomQuery = roomQuery.Where(r => !r.Bookings
                                     .Any(booking => (parameters.StartDate <= booking.StartDate && parameters.EndDate >= booking.EndDate)));
            }

            if (parameters.StartDate != null)
            {
                roomQuery = roomQuery.Where(r => !r.Bookings
                                     .Any(booking => (parameters.StartDate >= booking.StartDate && parameters.StartDate <= booking.EndDate)));
            }

            if (parameters.EndDate != null)
            {
                roomQuery = roomQuery.Where(r => !r.Bookings
                                     .Any(booking => (parameters.EndDate >= booking.StartDate && parameters.EndDate <= booking.EndDate)));
            }

            if (parameters.RoomType != null)
            {
                roomQuery = roomQuery.Where(r => r.RoomTypeId == parameters.RoomType);
            }

            if (parameters.CountOfPerson.HasValue)
            {
                roomQuery = roomQuery.Where(r => r.Occupacity == parameters.CountOfPerson);
            }

            return roomQuery.ToList();
        }
    }
}
