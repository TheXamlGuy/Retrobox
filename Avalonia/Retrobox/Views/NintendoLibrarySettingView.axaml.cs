using Avalonia.Controls;
using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class NintendoLibrarySettingView : SettingsExpander, IStyleable
    {
        public NintendoLibrarySettingView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.SettingsExpander);
    }
}