using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class PlaystationLibrarySettingViewModel : ILibrarySettingViewModel
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;
    public PlaystationLibrarySettingViewModel(IMediator mediator,
        PlaystationLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<PlaystationLibraryConfiguration>(args => args.IsOn = value));
}
