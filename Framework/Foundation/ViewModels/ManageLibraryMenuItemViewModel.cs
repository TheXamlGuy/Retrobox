using Mediator;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class ManageLibraryMenuItemViewModel : MenuItemViewModel
{
    public ManageLibraryMenuItemViewModel(IContentTemplateSelector contentTemplateSelector, 
        IMediator mediator) : base(contentTemplateSelector, mediator)
    {

    }
}