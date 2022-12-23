using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class LibraryCollectionViewModel : ObservableCollectionViewModel<ILibraryMenuItemViewModel>
{
    public LibraryCollectionViewModel(IMediator mediator) : base(mediator)
    {
        Add<NintendoLibraryMenuItemViewModel>();
        Add<PersonalComputerLibraryMenuItemViewModel>();
        Add<SegaLibraryMenuItemViewModel>();
        Add<XboxLibraryMenuItemViewModel>();
        Add<PlaystationLibraryMenuItemViewModel>();
    }
}