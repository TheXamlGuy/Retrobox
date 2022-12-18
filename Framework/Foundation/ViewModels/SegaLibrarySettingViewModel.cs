using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class SegaLibrarySettingViewModel : ILibrarySettingViewModel 
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;
    public SegaLibrarySettingViewModel(IMediator mediator,
        SegaLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<SegaLibraryConfiguration>(args => args.IsOn = value));
}
