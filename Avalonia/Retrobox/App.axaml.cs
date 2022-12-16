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
using Microsoft.Extensions.DependencyInjection.Extensions;
using Foundation;
using Mediator;

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
                configuration.Add<SegaLibraryItemViewModel, SegaLibraryItemView>();
                configuration.Add<NintendoLibraryItemViewModel, NintendoLibraryItemView>();
                configuration.Add<PlaystationLibraryItemViewModel, PlaystationLibraryItemView>();
                configuration.Add<XboxLibraryItemViewModel, XboxLibraryItemView>();
                configuration.Add<PersonalComputerLibraryItemViewModel, PersonalComputerLibraryItemView>();
                configuration.Add<ManageLibraryMenuItemViewModel, ManageLibraryMenuItemView>();
                configuration.Add<ManageLibraryViewModel, ManageLibraryView>("ManageLibrary");
            })
            .ConfigureServices(ConfigureServices)
        .Build();

        await host.RunAsync();
    }
    private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddHostedService<AppService>()
            .AddFoundation()
            .AddAvalonia()
            .AddDomain()
            .AddHandler<InitializedHandler>()
            .AddHandler<MainWindowActivationHandler>()
            .AddHandler<MainViewActivationHandler>()
            .AddSingleton<LibraryCollectionViewModel>()
            .AddSingleton<FooterCollectionViewModel>();
    }
}