using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Mediator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Retrobox.ViewModels;
using Retrobox.Views;
using System;
using System.IO;
using Toolkit.Foundation;
using Toolkit.Foundation.Avalonia;
using Avalonia.Markup.Xaml.Templates;
using System.Reflection.Metadata;
using Microsoft.Extensions.DependencyInjection.Extensions;
using FluentAvalonia.UI.Controls;

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
            .AddMediator(options => options.ServiceLifetime = ServiceLifetime.Transient);
    }
}