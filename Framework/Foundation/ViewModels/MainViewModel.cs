using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class MainViewModel
{
    [ObservableProperty]
    private IContentTemplateSelector templateSelector;

    [ObservableProperty]
    private IMediator? mediator;

    [ObservableProperty]
    private LibraryCollectionViewModel libraries;

    [ObservableProperty]
    private FooterCollectionViewModel footer;

    public MainViewModel(IMediator mediator,
        IContentTemplateSelector templateSelector,
        LibraryCollectionViewModel libraries,
        FooterCollectionViewModel footer)
    {
        this.mediator = mediator;
        this.templateSelector = templateSelector;
        this.libraries = libraries;
        this.footer = footer;
    }
}