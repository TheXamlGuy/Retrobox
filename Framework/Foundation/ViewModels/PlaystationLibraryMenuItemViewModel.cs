using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class PlaystationLibraryMenuItemViewModel : ILibraryMenuItemViewModel,
    INotificationHandler<ConfigurationChanged<PlaystationLibraryConfiguration>>
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    public PlaystationLibraryMenuItemViewModel(IMediator mediator,
        PlaystationLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        mediator.Subscribe(this);

        IsOn = configuration.IsOn;
    }

    public ValueTask Handle(ConfigurationChanged<PlaystationLibraryConfiguration> notification,
        CancellationToken cancellationToken)
    {
        IsOn = notification.Configuration.IsOn;
        return default;
    }
}