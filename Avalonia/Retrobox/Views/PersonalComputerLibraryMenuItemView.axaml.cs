using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class PersonalComputerLibraryMenuItemView : NavigationViewItem, IStyleable
{
    public PersonalComputerLibraryMenuItemView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.NavigationViewItem);
}