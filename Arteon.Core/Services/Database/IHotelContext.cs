using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Core.Services.Database
{
    public interface IHotelContext
    {
        DbSet<Room> Rooms { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<BookingService> BookingServices { get; set; }
        int SaveChanges();
    }
}
