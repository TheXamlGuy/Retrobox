using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class ManageLibraryView : ContentDialog, IStyleable
{
    public ManageLibraryView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.ContentDialog);
}