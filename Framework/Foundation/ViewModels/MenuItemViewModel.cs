using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class MenuItemViewModel : ObservableCollectionViewModel<MenuItemViewModel>
{
    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    [ObservableProperty]
    private IconViewModel? icon;

    [ObservableProperty]
    private bool isSelectable = false;

    [ObservableProperty]
    private bool isSelected;

    [ObservableProperty]
    private string name;

    public MenuItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator,
        string name,
        bool isSelectable = false) : base(mediator)
    {
        this.contentTemplateSelector = contentTemplateSelector;
        this.mediator = mediator;
        this.name = name;
        this.isSelectable = isSelectable;
    }
}