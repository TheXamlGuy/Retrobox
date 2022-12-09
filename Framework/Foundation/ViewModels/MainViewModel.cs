using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;

namespace Retrobox.Framework.Foundation;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private IMediator? mediator;

    public MainViewModel(IMediator mediator)
    {
        this.mediator = mediator;
    }
}