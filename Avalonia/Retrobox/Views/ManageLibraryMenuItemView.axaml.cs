using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class ManageLibraryMenuItemView : NavigationViewItem, IStyleable
{
    public ManageLibraryMenuItemView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.NavigationViewItem);
}
