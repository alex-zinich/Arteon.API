using Arteon.Core.Entities;
using Arteon.Core.Services.Database;

namespace Arteon.Infrastructure.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly IHotelContext _context;

        public BookingRepository(IHotelContext context)
        {
            _context = context;
        }

        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }
    }
}
