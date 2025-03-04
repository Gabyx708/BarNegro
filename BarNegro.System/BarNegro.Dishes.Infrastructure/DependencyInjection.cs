using BarNegro.Dishes.Domain.Interface;
using BarNegro.Dishes.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BarNegro.Dishes.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDishRepository, DishRepository>();

            return services;
        }
    }
}
