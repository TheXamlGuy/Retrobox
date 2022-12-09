using Data;
using Mediator;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using Toolkit.Foundation;

namespace Domain.Requests
{
    public class PlatformFamilyQueryHandler : IQueryHandler<PlatformFamilyQuery, IReadOnlyCollection<PlatformFamily>>
    {
        private readonly IServiceFactory factory;

        public PlatformFamilyQueryHandler(IServiceFactory factory)
        {
            this.factory = factory;
        }

        public async ValueTask<IReadOnlyCollection<PlatformFamily>> Handle(PlatformFamilyQuery query, CancellationToken cancellationToken)
        {
            List<PlatformFamily> result = new();

            using RetroboxContext? context = factory.Create<RetroboxContext>()!;

            await context.Platforms.GroupBy(x => x.Family).Select(x => new PlatformFamily(x.Key, new ReadOnlyCollection<Platform>(x.Select(x => new Platform(x.Name)).ToList()))).ToListAsync();

            result.AddRange(await context.Platforms.GroupBy(x => x.Family).Select(x => new PlatformFamily(x.Key, x.Select(x => new Platform(x.Name)).ToListAsync(cancellationToken));

            return result;
        }
    }
}