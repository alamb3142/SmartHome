using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Switchables.Infrastructure.Database;

namespace Switchables.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SwitchablesContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("Switchables"),
                    b =>
                    {
                        b.MigrationsAssembly(typeof(SwitchablesContext).Assembly.FullName);
                        b.EnableRetryOnFailure();
                    }
                );
            });

            return services;
        }
    }
}
