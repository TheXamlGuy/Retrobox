using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class NintendoLibraryItemViewModel : ILibraryItemViewModel
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public NintendoLibraryItemViewModel(IMediator mediator,
        IContentTemplateSelector contentTemplateSelector,
        NintendoLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        this.contentTemplateSelector = contentTemplateSelector;

        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<NintendoLibraryConfiguration>(args => args.IsOn = value));
}