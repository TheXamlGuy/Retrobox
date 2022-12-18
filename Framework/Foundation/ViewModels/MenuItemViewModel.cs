using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class MenuItemViewModel : ObservableCollectionViewModel<MenuItemViewModel>
{
    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public MenuItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator) : base(mediator)
    {
        this.contentTemplateSelector = contentTemplateSelector;
        this.mediator = mediator;
    }
}