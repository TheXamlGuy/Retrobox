using Mediator;
using System.Threading.Tasks;
using System.Threading;
using Retrobox.Views;
using Avalonia.Controls;
using Retrobox.Framework.Foundation;

namespace Retrobox;

public class MainWindowActivationHandler : IRequestHandler<MainWindowActivation, Window>
{
    private readonly MainWindow window;
    private readonly MainWindowModel viewModel;

    public MainWindowActivationHandler(MainWindow window, 
        MainWindowModel viewModel)
    {
        this.window = window;
        this.viewModel = viewModel;
    }

    public async ValueTask<Window> Handle(MainWindowActivation request, CancellationToken cancellationToken)
    {
        window.DataContext = viewModel;
        return await Task.FromResult(window);
    }
}
