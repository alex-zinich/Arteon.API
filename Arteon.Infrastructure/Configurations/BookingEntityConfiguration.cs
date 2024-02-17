using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Arteon.Infrastructure.Configurations
{
    internal class BookingEntityConfiguration : BaseEntityConfiguration<Booking>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(b => b.ClientId).IsRequired();
            builder.Property(b => b.RoomId).IsRequired();
            builder.Property(b => b.StartDate).IsRequired();
            builder.Property(b => b.EndDate).IsRequired();
        }
    }
}
