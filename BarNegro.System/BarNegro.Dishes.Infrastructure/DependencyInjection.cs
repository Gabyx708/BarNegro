using BarNegro.Dishes.Domain.Interface;
using BarNegro.Dishes.Infrastructure.Context;
using BarNegro.Dishes.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BarNegro.Dishes.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDishPersistenceServices(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDishRepository, DishRepository>();

            services.AddDbContext<DishContext>(options =>
           options.UseSqlite(connectionString));

            return services;
        }
    }
}
