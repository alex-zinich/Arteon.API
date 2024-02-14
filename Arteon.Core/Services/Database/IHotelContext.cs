using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Core.Services.Database
{
    public interface IHotelContext
    {
        DbSet<Room> Rooms { get; set; }
        int SaveChanges();
    }
}
