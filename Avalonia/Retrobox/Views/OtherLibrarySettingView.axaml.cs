using Avalonia.Controls;
using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class OtherLibrarySettingView : SettingsExpander, IStyleable
    {
        public OtherLibrarySettingView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.SettingsExpander);
    }
}