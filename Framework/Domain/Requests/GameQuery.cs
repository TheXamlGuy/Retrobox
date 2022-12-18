using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Domain;

public record GameQuery : IQuery<IReadOnlyCollection<Game>>;