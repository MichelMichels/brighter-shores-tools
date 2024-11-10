using BrighterShoresTools.Professions.Core.Services;
using BrighterShoresTools.Professions.Forager.Services;
using BrighterShoresTools.Professions.Guard.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Reflection;

namespace BrighterShoresTools.Frontend.ViewModels;

public partial class MainViewModel : WindowViewModel
{
    [ObservableProperty]
    private List<ProfessionCalculatorViewModel> _professionCalculators = [];

    [ObservableProperty]
    private ProfessionCalculatorViewModel? _selectedProfessionCalculator;

    [ObservableProperty]
    private string _version = string.Empty;

    public MainViewModel(
        GuardCalculator guardCalculator,
        ForagerCalculator foragerCalculator,
        IExperienceCalculator experienceCalculator)
    {
        _professionCalculators.Add(new ProfessionCalculatorViewModel("Guard", guardCalculator, @"/Resources/Images/guard-icon.png", experienceCalculator));
        _professionCalculators.Add(new ProfessionCalculatorViewModel("Forager", foragerCalculator, @"/Resources/Images/forager-icon.png", experienceCalculator));

        RetrieveVersion();
    }

    private void RetrieveVersion()
    {
        Version? version = Assembly.GetExecutingAssembly().GetName().Version;
        if (version is null)
        {
            return;
        }

        Version = $"v{version.Major}.{version.Minor}.{version.Build}";
    }

    partial void OnSelectedProfessionCalculatorChanged(ProfessionCalculatorViewModel? value)
    {
        if (value is null)
        {
            return;
        }

        if (value.CanCalculate)
        {
            value.CalculateCommand.Execute(null);
        }
    }
}
