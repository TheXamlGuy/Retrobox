using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class ManageLibraryCollectionViewModel :
    ObservableCollectionViewModel<ILibrarySettingViewModel>
{
    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public ManageLibraryCollectionViewModel(IMediator mediator,
        IContentTemplateSelector contentTemplateSelector) : base(mediator)
    {
        this.contentTemplateSelector = contentTemplateSelector;

        Add<NintendoLibrarySettingViewModel>();
        Add<PersonalComputerLibrarySettingViewModel>();
        Add<SegaLibrarySettingViewModel>();
        Add<XboxLibrarySettingViewModel>();
        Add<PlaystationLibrarySettingViewModel>();
        Add<OtherLibrarySettingViewModel>();
    }
}