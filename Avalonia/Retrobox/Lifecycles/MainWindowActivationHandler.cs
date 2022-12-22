using System.Threading.Tasks;
using System.Threading;
using Avalonia.Controls;
using Retrobox.Framework.Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox;

public class MainWindowActivationHandler : IRequestHandler<MainWindowActivation, Window>
{
    private readonly MainWindow window;
    private readonly MainWindowViewModel viewModel;

    public MainWindowActivationHandler(MainWindow window,
        MainWindowViewModel viewModel)
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
