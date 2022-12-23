using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class NintendoLibraryViewModel : ObservableCollectionViewModel<NintendoLibraryItemViewModel>
{
    public NintendoLibraryViewModel(IMediator mediator) : base(mediator)
    {
    }
}
