using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class PlaystationLibraryViewModel : ObservableCollectionViewModel<PlaystationLibraryItemViewModel>
{
    public PlaystationLibraryViewModel(IMediator mediator) : base(mediator)
    {
    }
}
