using Mediator;
using System.Threading.Tasks;
using System.Threading;
using Avalonia.Controls;
using Retrobox.Views;

namespace Retrobox;

public class MainViewActivationHandler : IRequestHandler<MainViewActivation, Control>
{
    private readonly MainView mainView;

    public MainViewActivationHandler(MainView mainView)
    {
        this.mainView = mainView;
    }

    public async ValueTask<Control> Handle(MainViewActivation request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(mainView);
    }
}
