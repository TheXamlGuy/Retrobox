﻿using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace Retrobox.Android;

[Activity(Label = "Retrobox.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
public class MainActivity : AvaloniaMainActivity
{
}
