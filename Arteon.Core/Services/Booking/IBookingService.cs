using Arteon.Core.Entities;

namespace Arteon.Core.Services
{
    public interface IBookingService
    {
        Task BookRoom(Booking booking);
    }
}
