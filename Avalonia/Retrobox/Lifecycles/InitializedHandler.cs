using System.Threading.Tasks;
using System.Threading;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia;
using Toolkit.Framework.Foundation;

namespace Retrobox;

public class InitializedHandler : IRequestHandler<Initialized>
{
    private readonly IMediator mediator;

    public InitializedHandler(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public async ValueTask<Unit> Handle(Initialized request, CancellationToken cancellationToken)
    {
        if (Application.Current is App app)
        {
            if (app.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime classicDesktopStyleApplicationLifetime)
            {
                classicDesktopStyleApplicationLifetime.MainWindow = await mediator.Send(new MainWindowActivation(), cancellationToken);
            }

            if (app.ApplicationLifetime is ISingleViewApplicationLifetime singleViewApplicationLifetime)
            {
                singleViewApplicationLifetime.MainView = await mediator.Send(new MainViewActivation(), cancellationToken);
            }
        }

        return default;
    }
}
