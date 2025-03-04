using System.Reflection;
using BarNegro.Dishes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarNegro.Dishes.Infrastructure.Context
{
    public class DishContext : DbContext
    {
        public DishContext(DbContextOptions<DishContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishCategory> DishesCategory { get; set; }
        public DbSet<PriceHistory> PriceHistory { get; set; }
    }
}
