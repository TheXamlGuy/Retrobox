using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[ObservableObject]
public partial class SettingsViewModel
{
    [ObservableProperty]
    private IMediator? mediator;

    public SettingsViewModel(IMediator mediator)
    {
        this.mediator = mediator;
    }
}
