using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Retrobox.Framework.Domain;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddDomain(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContextFactory<RetroboxContext>();
        return serviceCollection;
    }
}