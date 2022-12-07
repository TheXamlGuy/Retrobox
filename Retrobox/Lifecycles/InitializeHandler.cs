using Toolkit.Foundation;
using Mediator;
using System.Threading.Tasks;
using System.Threading;

namespace Retrobox;

public class InitializeHandler : IRequestHandler<Initialize>
{
    public ValueTask<Unit> Handle(Initialize request, CancellationToken cancellationToken)
    {
        return default;
    }
}
