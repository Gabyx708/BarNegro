using BarNegro.Dishes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarNegro.Dishes.Infrastructure.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<DishCategory>
    {
        public void Configure(EntityTypeBuilder<DishCategory> builder)
        {
            builder.HasKey(category => category.CategoryId);
            builder.Property(category => category.Description)
                            .IsRequired()
                            .HasMaxLength(100);
        }
    }
}
