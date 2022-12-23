using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class PersonalComputerLibraryMenuItemViewModel : ILibraryMenuItemViewModel,
    INotificationHandler<ConfigurationChanged<PersonalComputerLibraryConfiguration>>
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    public PersonalComputerLibraryMenuItemViewModel(IMediator mediator,
        PersonalComputerLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        mediator.Subscribe(this);

        IsOn = configuration.IsOn;
    }

    public ValueTask Handle(ConfigurationChanged<PersonalComputerLibraryConfiguration> notification,
        CancellationToken cancellationToken)
    {
        IsOn = notification.Configuration.IsOn;
        return default;
    }
}