using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class OtherLibraryItemViewModel : ILibraryItemViewModel,
    INotificationHandler<ConfigurationChanged<OtherLibraryConfiguration>>
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public OtherLibraryItemViewModel(IMediator mediator,
        IContentTemplateSelector contentTemplateSelector,
        OtherLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        this.contentTemplateSelector = contentTemplateSelector;

        IsOn = configuration.IsOn;
    }

    public ValueTask Handle(ConfigurationChanged<OtherLibraryConfiguration> notification,
        CancellationToken cancellationToken)
    {
        IsOn = notification.Configuration.IsOn;
        return default;
    }
}