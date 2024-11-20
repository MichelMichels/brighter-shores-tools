using BrighterShoresTools.Professions.Core.Models;

namespace BrighterShoresTools.Professions.Core.Services;

public abstract class ProfessionCalculator(
    IProfessionUnlockRepository professionUnlockRepository,
    IExperienceCalculator experienceCalculator)
    : IProfessionCalculator
{
    private const int NumberOfInventorySlots = 24;

    private readonly IProfessionUnlockRepository professionUnlockRepository = professionUnlockRepository ?? throw new ArgumentNullException(nameof(professionUnlockRepository));
    private readonly IExperienceCalculator experienceCalculator = experienceCalculator ?? throw new ArgumentNullException(nameof(experienceCalculator));

    private List<ProfessionUnlock> _professionUnlocks = [];

    public async Task<List<ProfessionCalculationResult>> CalculateNumberOfActions(int startLevel, int endLevel, double modifier = 1, bool isOnlyPossibleUnlocks = true)
    {
        await TryLoadUnlocks();

        List<ProfessionCalculationResult> results = [];

        int totalExperience = experienceCalculator.GetExperienceBetweenLevels(startLevel, endLevel);
        foreach (ProfessionUnlock unlock in _professionUnlocks.Where(x => !isOnlyPossibleUnlocks || x.Level <= endLevel))
        {
            int numberOfActions = totalExperience / (int)(unlock.ExperiencePoints * modifier);
            int numberOfInventories = numberOfActions / NumberOfInventorySlots + (numberOfActions % NumberOfInventorySlots > 0 ? 1 : 0);
            results.Add(new ProfessionCalculationResult(unlock, numberOfActions, numberOfInventories));
        }

        return results;
    }

    private async Task TryLoadUnlocks()
    {
        if (_professionUnlocks.Count == 0)
        {
            _professionUnlocks = await professionUnlockRepository.GetAll();
        }
    }
}
