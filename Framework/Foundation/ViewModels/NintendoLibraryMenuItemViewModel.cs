using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class NintendoLibraryMenuItemViewModel : ILibraryMenuItemViewModel,
    INotificationHandler<ConfigurationChanged<NintendoLibraryConfiguration>>
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    public NintendoLibraryMenuItemViewModel(IMediator mediator,
        NintendoLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        mediator.Subscribe(this);

        IsOn = configuration.IsOn;
    }

    public ValueTask Handle(ConfigurationChanged<NintendoLibraryConfiguration> notification,
    CancellationToken cancellationToken)
    {
        IsOn = notification.Configuration.IsOn;
        return default;
    }
}