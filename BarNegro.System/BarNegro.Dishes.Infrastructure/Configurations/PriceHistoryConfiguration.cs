using BarNegro.Dishes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarNegro.Dishes.Infrastructure.Configurations
{
    internal class PriceHistoryConfiguration : IEntityTypeConfiguration<PriceHistory>
    {
        public void Configure(EntityTypeBuilder<PriceHistory> builder)
        {
            builder.HasKey(ph => new { ph.UserId, ph.Date, ph.DishId });

            builder.Property(ph => ph.OriginalPrice).IsRequired();
            builder.Property(ph => ph.NewPrice).IsRequired();
            builder.Property(ph => ph.UserFullName).IsRequired();

            builder.HasOne(ph => ph.Dish)
                   .WithMany(d => d.PriceHistory)
                   .HasForeignKey(d => d.DishId);
        }
    }
}
