using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class PersonalComputerLibraryItemView : NavigationViewItem, IStyleable
{
    public PersonalComputerLibraryItemView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.NavigationViewItem);
}