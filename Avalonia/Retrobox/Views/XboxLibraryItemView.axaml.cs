using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class XboxLibraryItemView : NavigationViewItem, IStyleable
{
    public XboxLibraryItemView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.NavigationViewItem);
}