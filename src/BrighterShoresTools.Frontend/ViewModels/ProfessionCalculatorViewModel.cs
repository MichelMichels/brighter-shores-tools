using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace BrighterShoresTools.Frontend.ViewModels;

public partial class ProfessionCalculatorViewModel : ObservableValidator
{
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    [CustomValidation(typeof(ProfessionCalculatorViewModel), nameof(ValidateStartLevel))]
    private int _startLevel;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    [CustomValidation(typeof(ProfessionCalculatorViewModel), nameof(ValidateGoalLevel))]
    private int _goalLevel = 1;

    [ObservableProperty]
    private Dictionary<ProfessionUnlock, int> _results = [];

    public ProfessionCalculatorViewModel(string displayName, IProfessionCalculator calculator, string iconResource)
    {
        DisplayName = displayName;
        Calculator = calculator;
        IconResource = iconResource;

        ValidateAllProperties();
    }

    public string DisplayName { get; set; }
    public IProfessionCalculator Calculator { get; set; }
    public string IconResource { get; set; }

    public bool CanCalculate => !HasErrors;

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

    public static ValidationResult ValidateStartLevel(int value, ValidationContext context)
    {
        if (context.ObjectInstance is not ProfessionCalculatorViewModel viewModel)
        {
            return new ValidationResult("Invalid parent object");
        }

        viewModel.ClearErrors();

        if (value < 0)
        {
            return new("Must be positive.");
        }

        if (value >= viewModel.GoalLevel)
        {
            return new("Must be lower than goal");
        }

        return ValidationResult.Success!;
    }
    public static ValidationResult ValidateGoalLevel(int value, ValidationContext context)
    {
        if (context.ObjectInstance is not ProfessionCalculatorViewModel viewModel)
        {
            return new ValidationResult("Invalid parent object");
        }

        viewModel.ClearErrors();

        if (value < 0)
        {
            return new("Must be positive.");
        }

        if (value <= viewModel.StartLevel)
        {
            return new("Must be higher than start");
        }

        return ValidationResult.Success!;
    }
}
