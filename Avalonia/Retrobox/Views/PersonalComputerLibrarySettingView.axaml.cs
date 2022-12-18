using Avalonia.Controls;
using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class PersonalComputerLibrarySettingView : SettingsExpander, IStyleable
    {
        public PersonalComputerLibrarySettingView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.SettingsExpander);
    }
}