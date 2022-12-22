using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class SettingsView : ContentDialog, IStyleable
{
    public SettingsView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.ContentDialog);
}