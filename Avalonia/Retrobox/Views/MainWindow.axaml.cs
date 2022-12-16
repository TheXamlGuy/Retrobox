using Avalonia.Controls;
using Avalonia.Media.Immutable;
using Avalonia;
using FluentAvalonia.Styling;
using FluentAvalonia.UI.Media;
using FluentAvalonia.UI.Windowing;
using System.Runtime.InteropServices;
using Avalonia.Media;
using System;

namespace Retrobox;

public partial class MainWindow : AppWindow
{
    public MainWindow()
    {
        InitializeComponent();
        TitleBar.ExtendsContentIntoTitleBar = true;
    }

    protected override void OnOpened(EventArgs args)
    {
        base.OnOpened(args);
        if (AvaloniaLocator.Current.GetService<FluentAvaloniaTheme>() is FluentAvaloniaTheme theme)
        {
            theme.RequestedThemeChanged += OnRequestedThemeChanged;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IsWindows11 && theme.RequestedTheme != FluentAvaloniaTheme.HighContrastModeString)
                {
                    TransparencyBackgroundFallback = Brushes.Transparent;
                    TransparencyLevelHint = WindowTransparencyLevel.Mica;

                    TryEnableMicaEffect(theme);
                }
            }
        }
    }

    protected override void OnRequestedThemeChanged(FluentAvaloniaTheme sender, RequestedThemeChangedEventArgs args)
    {
        base.OnRequestedThemeChanged(sender, args);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (IsWindows11 && args.NewTheme != FluentAvaloniaTheme.HighContrastModeString)
            {
                TryEnableMicaEffect(sender);
            }
            else if (args.NewTheme == FluentAvaloniaTheme.HighContrastModeString)
            {
                SetValue(BackgroundProperty, AvaloniaProperty.UnsetValue);
            }
        }
    }

    private void TryEnableMicaEffect(FluentAvaloniaTheme theme)
    {
        if (theme.RequestedTheme == FluentAvaloniaTheme.DarkModeString)
        {
            var color = this.TryFindResource("SolidBackgroundFillColorBase", out var value) ? (Color2)(Color)value : new Color2(32, 32, 32);

            color = color.LightenPercent(-0.8f);
            Background = new ImmutableSolidColorBrush(color, 0.78);
        }
        else if (theme.RequestedTheme == FluentAvaloniaTheme.LightModeString)
        {
            var color = this.TryFindResource("SolidBackgroundFillColorBase", out var value) ? (Color2)(Color)value : new Color2(243, 243, 243);

            color = color.LightenPercent(0.5f);
            Background = new ImmutableSolidColorBrush(color, 0.9);
        }
    }
}