using Arteon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arteon.Infrastructure.Configurations
{
    internal class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        protected virtual void ConfigureEntity(EntityTypeBuilder<TEntity> builder) { }
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (typeof(TEntity).BaseType == typeof(BaseEntity))
            {
                builder.HasKey(o => (o as BaseEntity).Id);
                builder.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
            }

            ConfigureEntity(builder);
        }
    }
}
