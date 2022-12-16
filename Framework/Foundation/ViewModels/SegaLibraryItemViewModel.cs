using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class SegaLibraryItemViewModel : LibraryItemViewModel
{
    public SegaLibraryItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator) : base(contentTemplateSelector, mediator)
    {
    }
}