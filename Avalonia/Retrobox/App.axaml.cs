using Avalonia;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Retrobox.Views;
using System;
using System.IO;
using Retrobox.Framework.Foundation;
using Retrobox.Framework.Domain;
using Toolkit.Framework.Foundation;
using Toolkit.Framework.Avalonia;

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

                });

            })
            .ConfigureTemplates(configuration =>
            {
                configuration.Add<MainWindowModel, MainWindow>();
                configuration.Add<MainViewModel, MainView>("Main");
                configuration.Add<MenuItemViewModel, MenuItemView>();
                configuration.Add<SegaIconViewModel, SegaIconView>("SegaIcon");
                configuration.Add<NintendoIconViewModel, NintendoIconView>("NintendoIcon");
                configuration.Add<PlaystationIconViewModel, PlaystationIconView>("PlaystationIcon");
                configuration.Add<XboxIconViewModel, XboxIconView>("XboxIcon");
                configuration.Add<PersonalComputerIconViewModel, PersonalComputerView>("PCIcon");
                configuration.Add<AddPlatformIconViewModel, AddPlatformIconView>("AddIcon");
                configuration.Add<AddPlatformViewModel, AddPlatformView>();
            })
            .ConfigureServices(ConfigureServices)
        .Build();

        await host.RunAsync();
    }
    private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddHostedService<AppService>()
            .AddFoundation()
            .AddNavigation()
            .AddDomain()
            .AddMediator(options => options.ServiceLifetime = ServiceLifetime.Transient)
            .AddSingleton<MenuCollectionViewModel>()
            .AddSingleton<FooterCollectionViewModel>();
    }
}