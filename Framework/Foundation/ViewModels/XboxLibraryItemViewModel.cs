using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class XboxLibraryItemViewModel : LibraryItemViewModel
{
    public XboxLibraryItemViewModel(IContentTemplateSelector contentTemplateSelector,
        IMediator mediator) : base(contentTemplateSelector, mediator)
    {
    }
}