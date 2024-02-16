using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arteon.Infrastructure.Configurations
{
    internal class RoomTypeEntityConfiguration : BaseEntityConfiguration<RoomType>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<RoomType> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(32);
        }
    }
}
