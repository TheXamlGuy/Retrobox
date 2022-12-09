using Data;
using Mediator;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using Toolkit.Foundation;

namespace Retrobox.Framework.Domain;

public class PlatformFamilyQueryHandler : IQueryHandler<PlatformFamilyQuery, IReadOnlyCollection<PlatformFamily>>
{
    private readonly IDbContextFactory<RetroboxContext> factory;

    public PlatformFamilyQueryHandler(IDbContextFactory<RetroboxContext> factory)
    {
        this.factory = factory;
    }

    public async ValueTask<IReadOnlyCollection<PlatformFamily>> Handle(PlatformFamilyQuery query, CancellationToken cancellationToken)
    {
        List<PlatformFamily> result = new();

        using RetroboxContext? context = await factory.CreateDbContextAsync();
        result.AddRange(await context.PlatformFamilies.Include(x => x.Platforms).Select(x => new PlatformFamily(x.Name, new ReadOnlyCollection<Platform>(x.Platforms.Select(x => new Platform(x.Name)).ToList()))).ToListAsync(cancellationToken: cancellationToken));

        return result;
    }
}