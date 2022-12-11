using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class MainViewModel
{
    [ObservableProperty]
    private ITemplateSelector templateSelector;

    [ObservableProperty]
    private IMediator? mediator;

    [ObservableProperty]
    private MenuCollectionViewModel menu;

    [ObservableProperty]
    private FooterCollectionViewModel footer;

    public MainViewModel(IMediator mediator, 
        ITemplateSelector templateSelector,
        MenuCollectionViewModel menu,
        FooterCollectionViewModel footer)
    {
        this.mediator = mediator;
        this.templateSelector = templateSelector;
        this.menu = menu;
        this.footer = footer;
    }
}