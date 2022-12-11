using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class MenuItemViewModel : ObservableCollectionViewModel<MenuItemViewModel>
{
    [ObservableProperty]
    private string name;


    [ObservableProperty]
    private IconViewModel? icon;

    [ObservableProperty]
    private ITemplateSelector templateSelector;

    public MenuItemViewModel(string name, 
        IconViewModel icon, 
        ITemplateSelector templateSelector,
        IMediator mediator) : base(mediator)
    {
        this.name = name;
        this.icon = icon;
        this.templateSelector = templateSelector;
    }
}