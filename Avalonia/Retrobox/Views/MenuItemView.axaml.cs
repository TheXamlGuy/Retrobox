using Avalonia.Styling;
using System;
using Toolkit.Controls.Avalonia;

namespace Retrobox
{
    public partial class MenuItemView : NavigationViewItem, IStyleable
    {
        public MenuItemView()
        {
            InitializeComponent();
        }

        Type IStyleable.StyleKey => typeof(FluentAvalonia.UI.Controls.NavigationViewItem);
    }
}