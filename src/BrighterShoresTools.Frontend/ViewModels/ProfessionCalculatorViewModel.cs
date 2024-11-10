using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace BrighterShoresTools.Frontend.ViewModels;

public partial class ProfessionCalculatorViewModel : ObservableValidator
{
    private readonly IExperienceCalculator experienceCalculator;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    [CustomValidation(typeof(ProfessionCalculatorViewModel), nameof(ValidateStartLevel))]
    private int _startLevel;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    [CustomValidation(typeof(ProfessionCalculatorViewModel), nameof(ValidateGoalLevel))]
    private int _goalLevel;

    [ObservableProperty]
    private int _startExperience;

    [ObservableProperty]
    private int _goalExperience;

    [ObservableProperty]
    private Dictionary<ProfessionUnlock, int> _results = [];

    [ObservableProperty]
    private List<PotionModifierViewModel> _potionModifiers = [
        new PotionModifierViewModel("No potion", 1),
        new PotionModifierViewModel("5% potion (level 4)", 1.05),
        new PotionModifierViewModel("6% potion (level 41)", 1.06),
        new PotionModifierViewModel("7% potion (level 50)", 1.07),
        new PotionModifierViewModel("8% potion (level 176)", 1.08),
        new PotionModifierViewModel("10% potion (level 185)", 1.10),
    ];

    [ObservableProperty]
    [Required]
    [NotifyCanExecuteChangedFor(nameof(CalculateCommand))]
    private PotionModifierViewModel _selectedPotionModifier;

    [ObservableProperty]
    private bool _isOnlyPossibleUnlocksVisible = true;

    public ProfessionCalculatorViewModel(string displayName, IProfessionCalculator calculator, string iconResource, IExperienceCalculator experienceCalculator)
    {
        DisplayName = displayName;
        Calculator = calculator;
        IconResource = iconResource;

        this.experienceCalculator = experienceCalculator ?? throw new ArgumentNullException(nameof(experienceCalculator));

        _selectedPotionModifier = PotionModifiers.First();
        GoalLevel = 1;

        ValidateAllProperties();
    }

    public string DisplayName { get; set; }
    public IProfessionCalculator Calculator { get; set; }
    public string IconResource { get; set; }

    public bool CanCalculate => !HasErrors;

    [RelayCommand(CanExecute = nameof(CanCalculate))]
    private async Task Calculate()
    {
        Results = await Calculator.CalculateNumberOfActions(StartLevel, GoalLevel, SelectedPotionModifier.Modifier, IsOnlyPossibleUnlocksVisible);

    }

    async partial void OnStartLevelChanged(int value)
    {
        if (CanCalculate)
        {
            await Calculate();
        }

        StartExperience = experienceCalculator.GetExperienceFromLevel(value);
    }
    async partial void OnGoalLevelChanged(int value)
    {
        if (CanCalculate)
        {
            await Calculate();
        }

        GoalExperience = experienceCalculator.GetExperienceFromLevel(value);
    }
    async partial void OnSelectedPotionModifierChanged(PotionModifierViewModel value)
    {
        if (CanCalculate)
        {
            await Calculate();
        }
    }
    async partial void OnIsOnlyPossibleUnlocksVisibleChanged(bool value)
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
