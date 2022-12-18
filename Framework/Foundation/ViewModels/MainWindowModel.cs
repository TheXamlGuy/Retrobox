using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

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