using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class XboxLibrarySettingViewModel : ILibrarySettingViewModel 
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;
    public XboxLibrarySettingViewModel(IMediator mediator,
        XboxLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<XboxLibraryConfiguration>(args => args.IsOn = value));
}
