using Data;
using Microsoft.EntityFrameworkCore;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Domain;

public class PlatformQueryHandler : IQueryHandler<PlatformQuery, IReadOnlyCollection<Platform>>
{
    private readonly IServiceFactory factory;

    public PlatformQueryHandler(IServiceFactory factory)
    {
        this.factory = factory;
    }

    public async ValueTask<IReadOnlyCollection<Platform>> Handle(PlatformQuery query, CancellationToken cancellationToken)
    {
        List<Platform> result = new();

        using RetroboxContext? context = factory.Create<RetroboxContext>()!;
        result.AddRange(await context.Platforms.Select(x => new Platform(x.Name)).ToListAsync(cancellationToken));

        return result;
    }
}