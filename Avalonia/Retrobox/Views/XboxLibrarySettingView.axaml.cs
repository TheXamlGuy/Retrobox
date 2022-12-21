using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox;

public partial class XboxLibrarySettingView : SettingsExpander, IStyleable
{
    public XboxLibrarySettingView()
    {
        InitializeComponent();
    }

    Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.SettingsExpander);
}