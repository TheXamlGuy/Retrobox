using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class SegaLibraryViewModel : ObservableCollectionViewModel<SegaLibraryItemViewModel>
{
    public SegaLibraryViewModel(IMediator mediator) : base(mediator)
    {
    }
}
