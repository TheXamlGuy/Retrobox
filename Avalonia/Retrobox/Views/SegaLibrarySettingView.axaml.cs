using Avalonia.Controls;
using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class SegaLibrarySettingView : SettingsExpander, IStyleable
    {
        public SegaLibrarySettingView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.SettingsExpander);
    }
}