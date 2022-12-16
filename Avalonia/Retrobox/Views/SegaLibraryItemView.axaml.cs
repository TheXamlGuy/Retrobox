using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class SegaLibraryItemView : NavigationViewItem, IStyleable
{
    public SegaLibraryItemView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.NavigationViewItem);
}