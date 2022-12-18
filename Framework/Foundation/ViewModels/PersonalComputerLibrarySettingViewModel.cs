using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class PersonalComputerLibrarySettingViewModel : ILibrarySettingViewModel
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;
    public PersonalComputerLibrarySettingViewModel(IMediator mediator,
        PersonalComputerLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<PersonalComputerLibraryConfiguration>(args => args.IsOn = value));
}
