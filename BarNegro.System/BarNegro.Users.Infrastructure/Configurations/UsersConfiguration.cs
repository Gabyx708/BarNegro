using BarNegro.Users.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarNegro.Users.Infrastructure.Configurations
{
    internal class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.Password).IsRequired();
        }
    }
}
