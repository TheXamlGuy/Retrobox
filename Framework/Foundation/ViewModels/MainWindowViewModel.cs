using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    private IMediator? mediator;

    public MainWindowViewModel(IMediator mediator)
    {
        this.mediator = mediator;
    }
}