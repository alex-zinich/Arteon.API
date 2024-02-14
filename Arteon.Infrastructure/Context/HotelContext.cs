using Arteon.Core.Entities;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Arteon.Infrastructure.Context
{
    public class HotelContext : DbContext, IHotelContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Room> Rooms { get; set; }

        public override int SaveChanges()
        {
            SetTime();
            return base.SaveChanges();
        }

        private void SetTime()
        {
            IEnumerable<EntityEntry> modifiedEntries = ChangeTracker.Entries()
               .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            DateTime now = DateTime.Now;
            foreach (EntityEntry entry in modifiedEntries)
            {
                if (entry.Entity is not BaseEntity entity)
                {
                    continue;
                }

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = now;
                }

                entity.ModifiedOn = now;
            }
        }
    }
}
