using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Application.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace BarNegro.Dishes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDishApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateDish, CreateDish>();
            services.AddScoped<IChangeDishPrice, ChangePriceDish>();
            services.AddScoped<IQueryDish, QueryDish>();
            return services;
        }
    }
}
