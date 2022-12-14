using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class MenuCollectionViewModel : ObservableCollectionViewModel<MenuItemViewModel>
{
    public MenuCollectionViewModel(IMediator mediator) : base(mediator)
    {
        Add("Nintendo");
        Add("PC");
        Add("Sega");
        Add("Xbox");
        Add("Playstation");
        Add("Others");
    }
}