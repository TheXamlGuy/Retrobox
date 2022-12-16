using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class OtherLibraryItemViewModel : LibraryItemViewModel
{
    public OtherLibraryItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator) : base(contentTemplateSelector, mediator)
    {
    }
}