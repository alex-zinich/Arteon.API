using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arteon.Infrastructure.Configurations
{
    internal class RoomEntityConfiguration : BaseEntityConfiguration<Room>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Room> builder)
        {
        }
    }
}
