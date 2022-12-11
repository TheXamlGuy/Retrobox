using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class FooterCollectionViewModel : ObservableCollectionViewModel<MenuItemViewModel>
{
    public FooterCollectionViewModel(IMediator mediator) : base(mediator)
    {
        Add<MenuItemViewModel>("Add", new AddPlatformIconViewModel());
    }
}