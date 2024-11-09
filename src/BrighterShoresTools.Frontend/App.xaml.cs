using BrighterShoresTools.Frontend.ViewModels;
using BrighterShoresTools.Professions.Core.Services;
using BrighterShoresTools.Professions.Forager.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BrighterShoresTools.Frontend;

public partial class App : Application
{
    public IServiceProvider ServiceProvider { get; private set; } = default!;

    protected override void OnStartup(StartupEventArgs e)
    {
        ServiceCollection serviceCollection = new();
        ConfigureServices(serviceCollection);

        ServiceProvider = serviceCollection.BuildServiceProvider();

        MainView mainView = ServiceProvider.GetRequiredService<MainView>();
        mainView.Show();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<MainView>();
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<ForagerCalculator>();
        services.AddSingleton<IForagerUnlockRepository, ForagerUnlockRepository>();
        services.AddSingleton<IExperienceCalculator, ExperienceCalculator>();
    }
}
