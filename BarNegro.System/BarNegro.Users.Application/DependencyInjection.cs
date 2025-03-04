using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Application.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace BarNegro.Users.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateUser, CreateUser>();
            services.AddScoped<IDesactivateUser, DesactivateUser>();
            services.AddScoped<IQueryUser, QueryUser>();
            services.AddScoped<IUpdateUser, UpdateUser>();

            return services;
        }
    }
}
