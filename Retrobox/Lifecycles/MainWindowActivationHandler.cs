using Mediator;
using System.Threading.Tasks;
using System.Threading;
using Retrobox.Views;
using Avalonia.Controls;

namespace Retrobox;

public class MainWindowActivationHandler : IRequestHandler<MainWindowActivation, Window>
{
    private readonly MainWindow window;

    public MainWindowActivationHandler(MainWindow window)
    {
        this.window = window;
    }

    public async ValueTask<Window> Handle(MainWindowActivation request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(window);
    }
}
