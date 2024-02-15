using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arteon.Infrastructure.Configurations
{
    internal class BookingServiceEntityConfiguration : BaseEntityConfiguration<BookingService>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<BookingService> builder)
        {
        }
    }
}
