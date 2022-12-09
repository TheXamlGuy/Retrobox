using Foundation;
using Avalonia;
using Avalonia.iOS;

namespace Retrobox.iOS;

[Register("AppDelegate")]
public partial class AppDelegate : AvaloniaAppDelegate<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return builder;
    }
}
