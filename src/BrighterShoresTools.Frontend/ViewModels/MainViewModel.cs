using BrighterShoresTools.Professions.Forager.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BrighterShoresTools.Frontend.ViewModels;

public partial class MainViewModel : WindowViewModel
{

    [ObservableProperty]
    private List<ProfessionCalculatorViewModel> _professionCalculators = [];

    [ObservableProperty]
    private ProfessionCalculatorViewModel? _selectedProfessionCalculator;

    public MainViewModel(ForagerCalculator foragerCalculator)
    {
        _professionCalculators.Add(new ProfessionCalculatorViewModel("Forager", foragerCalculator));
    }
}
