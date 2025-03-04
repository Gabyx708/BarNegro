using BarNegro.Users.Domain.Interfaces;
using BarNegro.Users.Infrastructure.Context;
using BarNegro.Users.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BarNegro.Users.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<UserContext>(options =>
            options.UseInMemoryDatabase("UserInMemoryDb"));

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
