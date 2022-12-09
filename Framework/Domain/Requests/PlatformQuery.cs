using Mediator;

namespace Domain.Requests
{
    public record PlatformQuery : IQuery<IReadOnlyCollection<Platform>>;
}