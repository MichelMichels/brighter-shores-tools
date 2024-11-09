using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BrighterShoresTools.Frontend.ViewModels;

public partial class ProfessionCalculatorViewModel(string displayName, IProfessionCalculator calculator, string iconResource) : ObservableValidator
{
    public string DisplayName { get; set; } = displayName;
    public IProfessionCalculator Calculator { get; set; } = calculator;
    public string IconResource { get; set; } = iconResource;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    private int _startLevel;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    private int _goalLevel;

    [ObservableProperty]
    private Dictionary<ProfessionUnlock, int> _results = [];

    public bool CanCalculate => StartLevel < GoalLevel;

    [RelayCommand(CanExecute = nameof(CanCalculate))]
    private async Task Calculate()
    {
        Results = await Calculator.CalculateNumberOfActions(StartLevel, GoalLevel);
    }

    async partial void OnStartLevelChanged(int value)
    {
        if (CanCalculate)
        {
            await Calculate();
        }
    }
    async partial void OnGoalLevelChanged(int value)
    {
        if (CanCalculate)
        {
            await Calculate();
        }
    }
}
