using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class XboxLibraryViewModel : ObservableCollectionViewModel<XboxLibraryItemViewModel>
{
    public XboxLibraryViewModel(IMediator mediator) : base(mediator)
    {
    }
}
