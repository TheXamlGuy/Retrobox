using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class XboxLibraryItemViewModel : ILibraryItemViewModel
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    [ObservableProperty]
    private IContentTemplateSelector contentTemplateSelector;

    public XboxLibraryItemViewModel(IMediator mediator,
        IContentTemplateSelector contentTemplateSelector,
        XboxLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        this.contentTemplateSelector = contentTemplateSelector;

        isOn = configuration.IsOn;
    }

    partial void OnIsOnChanged(bool value) => mediator.Send(new Write<XboxLibraryConfiguration>(args => args.IsOn = value));
}