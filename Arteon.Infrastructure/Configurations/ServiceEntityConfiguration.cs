using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Arteon.Infrastructure.Configurations
{
    internal class ServiceEntityConfiguration : BaseEntityConfiguration<Service>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(32);
        }
    }
}
