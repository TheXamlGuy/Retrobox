using CommunityToolkit.Mvvm.ComponentModel;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class ManageLibraryViewModel
{

    [ObservableProperty]
    private LibraryCollectionViewModel libraries;

    public ManageLibraryViewModel(LibraryCollectionViewModel libraries)
    {
        this.libraries = libraries;
    }
}
