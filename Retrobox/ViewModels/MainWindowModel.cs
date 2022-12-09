using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;

namespace Retrobox.ViewModels;

[ObservableObject]
public partial class MainWindowModel
{
    [ObservableProperty]
    private IMediator? mediator;

    public MainWindowModel(IMediator mediator)
    {
        this.mediator = mediator;
    }
}