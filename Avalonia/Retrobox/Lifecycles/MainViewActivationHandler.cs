using Mediator;
using System.Threading.Tasks;
using System.Threading;
using Avalonia.Controls;
using Retrobox.Views;
using Retrobox.Framework.Foundation;

namespace Retrobox;

public class MainViewActivationHandler : IRequestHandler<MainViewActivation, Control>
{
    private readonly MainView view;
    private readonly MainViewModel viewModel;

    public MainViewActivationHandler(MainView view, 
        MainViewModel viewModel)
    {
        this.view = view;
        this.viewModel = viewModel;
    }

    public async ValueTask<Control> Handle(MainViewActivation request, CancellationToken cancellationToken)
    {
        view.DataContext = viewModel;
        return await Task.FromResult(view);
    }
}
