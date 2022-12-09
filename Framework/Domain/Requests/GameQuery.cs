using Mediator;

namespace Retrobox.Framework.Domain;

public record GameQuery : IQuery<IReadOnlyCollection<Game>>;