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
        services.AddTransient(typeof(MainView));
    }
}
