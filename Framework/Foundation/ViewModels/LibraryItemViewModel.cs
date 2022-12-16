using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class LibraryItemViewModel
{
    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public LibraryItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator)
    {
        this.contentTemplateSelector = contentTemplateSelector;
        this.mediator = mediator;
    }

    partial void OnIsOnChanged(bool value)
    {

    }
}
