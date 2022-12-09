using Mediator;

namespace Retrobox.Framework.Domain;

public record PlatformFamilyQuery : IQuery<IReadOnlyCollection<PlatformFamily>>;
