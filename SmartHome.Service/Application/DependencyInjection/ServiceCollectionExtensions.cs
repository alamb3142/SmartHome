using System.Net.Security;
using System.Reflection.PortableExecutable;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Common;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(typeof(ServiceCollectionExtensions).Assembly));
        return services;
    }
}
