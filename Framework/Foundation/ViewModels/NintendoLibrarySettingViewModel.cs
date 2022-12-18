using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class NintendoLibrarySettingViewModel : ILibrarySettingViewModel
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;
    public NintendoLibrarySettingViewModel(IMediator mediator,
        NintendoLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<NintendoLibraryConfiguration>(args => args.IsOn = value));
}
