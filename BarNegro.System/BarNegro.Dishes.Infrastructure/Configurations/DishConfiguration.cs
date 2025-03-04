using BarNegro.Dishes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarNegro.Dishes.Infrastructure.Configurations
{
    internal class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasKey(d => d.DishId);

            builder.Property(d => d.Description)
                            .IsRequired()
                            .HasMaxLength(200);

            builder.Property(d => d.Price).IsRequired();
            builder.Property(d => d.CreationDate).IsRequired();
            builder.Property(d => d.CategoryId).IsRequired();

            builder.HasOne(d => d.Category)
                   .WithMany(c => c.Dishes)
                   .HasForeignKey(d => d.CategoryId);

        }
    }
}
