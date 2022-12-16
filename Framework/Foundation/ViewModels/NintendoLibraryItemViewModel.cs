using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class NintendoLibraryItemViewModel : LibraryItemViewModel
{
    public NintendoLibraryItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator) : base(contentTemplateSelector, mediator)
    {

    }
}
