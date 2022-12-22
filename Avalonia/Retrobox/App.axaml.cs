using Avalonia;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using Retrobox.Framework.Foundation;
using Retrobox.Framework.Domain;
using Toolkit.Framework.Foundation;
using Toolkit.Framework.Avalonia;
using Foundation;
using System.Reflection;

namespace Retrobox;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override async void OnFrameworkInitializationCompleted()
    {
        base.OnFrameworkInitializationCompleted();

        IHost? host = new HostBuilder()
            .UseContentRoot(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Retrobox"), true)
            .ConfigureAppConfiguration((context, configuration) =>
            {
                configuration.AddWritableJsonFile("Settings.json", false, true, writableConfiguration =>
                {
                    writableConfiguration.AddDefaultFileStream(Assembly.GetExecutingAssembly().ExtractResource("Settings.json")!)
                       .AddDefaultConfiguration<NintendoLibraryConfiguration>("NintendoLibrary")
                       .AddDefaultConfiguration<PersonalComputerLibraryConfiguration>("PersonalComputerLibrary")
                       .AddDefaultConfiguration<PlaystationLibraryConfiguration>("PlaystationLibrary")
                       .AddDefaultConfiguration<SegaLibraryConfiguration>("SegaLibrary")
                       .AddDefaultConfiguration<XboxLibraryConfiguration>("XboxLibrary")
                       .AddDefaultConfiguration<OtherLibraryConfiguration>("OtherLibrary");
                });
            })
            .ConfigureContents(configuration =>
            {
                configuration.Add<MainWindowViewModel, MainWindow>();
                configuration.Add<MainViewModel, MainView>("Main");
                configuration.Add<SettingsViewModel, SettingsView>("Settings");
                configuration.Add<SegaLibraryItemViewModel, SegaLibraryItemView>(ServiceLifetime.Singleton);
                configuration.Add<SegaLibrarySettingViewModel, SegaLibrarySettingView>();
                configuration.Add<NintendoLibraryItemViewModel, NintendoLibraryItemView>(ServiceLifetime.Singleton);
                configuration.Add<NintendoLibrarySettingViewModel, NintendoLibrarySettingView>();
                configuration.Add<PlaystationLibraryItemViewModel, PlaystationLibraryItemView>(ServiceLifetime.Singleton);
                configuration.Add<PlaystationLibrarySettingViewModel, PlaystationLibrarySettingView>();
                configuration.Add<XboxLibraryItemViewModel, XboxLibraryItemView>(ServiceLifetime.Singleton);
                configuration.Add<XboxLibrarySettingViewModel, XboxLibrarySettingView>();
                configuration.Add<PersonalComputerLibraryItemViewModel, PersonalComputerLibraryItemView>(ServiceLifetime.Singleton);
                configuration.Add<PersonalComputerLibrarySettingViewModel, PersonalComputerLibrarySettingView>();
                configuration.Add<ManageLibraryCollectionMenuItemViewModel, ManageLibraryMenuItemView>();
                configuration.Add<ManageLibraryCollectionViewModel, ManageLibraryCollectionView>("ManageLibrary");
            })
            .ConfigureServices(ConfigureServices)
        .Build();

        await host.RunAsync();
    }
    private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddHostedService<AppService>()
            .AddHandler<InitializedHandler>()
            .AddHandler<MainWindowActivationHandler>()
            .AddHandler<MainViewActivationHandler>()
            .AddSingleton<LibraryCollectionViewModel>()
            .AddSingleton<FooterCollectionViewModel>()
            .AddWritableConfiguration<NintendoLibraryConfiguration>(context.Configuration.GetSection("NintendoLibrary"))
            .AddWritableConfiguration<PersonalComputerLibraryConfiguration>(context.Configuration.GetSection("PersonalComputerLibrary"))
            .AddWritableConfiguration<PlaystationLibraryConfiguration>(context.Configuration.GetSection("PlaystationLibrary"))
            .AddWritableConfiguration<SegaLibraryConfiguration>(context.Configuration.GetSection("SegaLibrary"))
            .AddWritableConfiguration<XboxLibraryConfiguration>(context.Configuration.GetSection("XboxLibrary"))
            .AddWritableConfiguration<OtherLibraryConfiguration>(context.Configuration.GetSection("OtherLibrary"))
            .AddFoundation()
            .AddAvalonia()
            .AddDomain();
    }
}