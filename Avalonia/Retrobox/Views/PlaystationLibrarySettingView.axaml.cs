using Avalonia.Controls;
using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class PlaystationLibrarySettingView : SettingsExpander, IStyleable
    {
        public PlaystationLibrarySettingView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.SettingsExpander);
    }
}