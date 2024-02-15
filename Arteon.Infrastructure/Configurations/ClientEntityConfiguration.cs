using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arteon.Infrastructure.Configurations
{
    internal class ClientEntityConfiguration : BaseEntityConfiguration<Client>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(64);
        }
    }
}
