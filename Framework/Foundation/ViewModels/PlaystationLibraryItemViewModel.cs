using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class PlaystationLibraryItemViewModel : LibraryItemViewModel
{
    public PlaystationLibraryItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator) : base(contentTemplateSelector, mediator)
    {
    }
}