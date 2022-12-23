using CommunityToolkit.Mvvm.ComponentModel;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class PersonalComputerLibraryViewModel : ObservableCollectionViewModel<PersonalComputerLibraryItemViewModel>
{
    public PersonalComputerLibraryViewModel(IMediator mediator) : base(mediator)
    {
    }
}
