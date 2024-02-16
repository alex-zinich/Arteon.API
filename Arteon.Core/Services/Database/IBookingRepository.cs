using Arteon.Core.Entities;

namespace Arteon.Core.Services.Database
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
    }
}
