using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class FooterCollectionViewModel : ObservableCollectionViewModel<MenuItemViewModel>
{
    public FooterCollectionViewModel(IMediator mediator) : base(mediator)
    {
        Add<ManageLibraryCollectionMenuItemViewModel>();
    }
}