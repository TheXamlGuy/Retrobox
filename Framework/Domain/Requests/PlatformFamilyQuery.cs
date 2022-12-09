using Mediator;

namespace Domain.Requests
{
    public record PlatformFamilyQuery : IQuery<IReadOnlyCollection<PlatformFamily>>;

}