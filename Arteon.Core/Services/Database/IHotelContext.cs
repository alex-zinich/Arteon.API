using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using BookingServicesEntities = Arteon.Core.Entities.BookingService;

namespace Arteon.Core.Services.Database
{
    public interface IHotelContext
    {
        DbSet<Room> Rooms { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<BookingServicesEntities> BookingServices { get; set; }
        DbSet<RoomType> RoomTypes { get; set; }
        int SaveChanges();
    }
}
