using Mediator;

namespace Retrobox.Framework.Domain;

public record PlatformQuery : IQuery<IReadOnlyCollection<Platform>>;