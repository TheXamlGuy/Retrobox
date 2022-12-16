using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class LibraryCollectionViewModel : ObservableCollectionViewModel<LibraryItemViewModel>
{
    public LibraryCollectionViewModel(IMediator mediator) : base(mediator)
    {
        Add<NintendoLibraryItemViewModel>();
        Add<PersonalComputerLibraryItemViewModel>();
        Add<SegaLibraryItemViewModel>();
        Add<XboxLibraryItemViewModel>();
        Add<PlaystationLibraryItemViewModel>();
        Add<OtherLibraryItemViewModel>();
    }
}