using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class OtherLibraryItemViewModel : ILibraryItemViewModel
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public OtherLibraryItemViewModel(IMediator mediator,
        IContentTemplateSelector contentTemplateSelector)
    {
        this.mediator = mediator;
        this.contentTemplateSelector = contentTemplateSelector;
    }

    partial void OnIsOnChanged(bool value)
    {
        Console.WriteLine($"Name is about to change to {value}");
    }
}