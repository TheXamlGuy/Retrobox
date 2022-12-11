using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class AddPlatformView : ContentDialog, IStyleable
    {
        public AddPlatformView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.ContentDialog);
    }
}