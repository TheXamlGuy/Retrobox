using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class ManageLibraryCollectionView : ContentDialog, IStyleable
{
    public ManageLibraryCollectionView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.ContentDialog);
}