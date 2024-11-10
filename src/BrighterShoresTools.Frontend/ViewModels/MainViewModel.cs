using BrighterShoresTools.Professions.Forager.Services;
using BrighterShoresTools.Professions.Guard.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BrighterShoresTools.Frontend.ViewModels;

public partial class MainViewModel : WindowViewModel
{
    [ObservableProperty]
    private List<ProfessionCalculatorViewModel> _professionCalculators = [];

    [ObservableProperty]
    private ProfessionCalculatorViewModel? _selectedProfessionCalculator;

    public MainViewModel(
        GuardCalculator guardCalculator,
        ForagerCalculator foragerCalculator)
    {
        _professionCalculators.Add(new ProfessionCalculatorViewModel("Guard", guardCalculator, @"/Resources/Images/guard-icon.png"));
        _professionCalculators.Add(new ProfessionCalculatorViewModel("Forager", foragerCalculator, @"/Resources/Images/forager-icon.png"));
    }
}
