using Mediator;

namespace Domain.Requests
{
    public record GameQuery : IQuery<IReadOnlyCollection<Game>>;

}