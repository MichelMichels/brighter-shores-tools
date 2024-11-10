using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Core.Services;

public abstract class ProfessionCalculator(
    IProfessionUnlockRepository professionUnlockRepository,
    IExperienceCalculator experienceCalculator)
    : IProfessionCalculator
{
    private readonly IProfessionUnlockRepository professionUnlockRepository = professionUnlockRepository ?? throw new ArgumentNullException(nameof(professionUnlockRepository));
    private readonly IExperienceCalculator experienceCalculator = experienceCalculator ?? throw new ArgumentNullException(nameof(experienceCalculator));

    private static List<ProfessionUnlock> _professionUnlocks = [];

    public async Task<Dictionary<ProfessionUnlock, int>> CalculateNumberOfActions(int startLevel, int endLevel, double modifier)
    {
        await TryLoadUnlocks();

        Dictionary<ProfessionUnlock, int> result = [];

        int totalExperience = experienceCalculator.GetExperienceBetweenLevels(startLevel, endLevel);
        foreach (ProfessionUnlock unlock in _professionUnlocks)
        {
            result.Add(unlock, totalExperience / (int)(unlock.ExperiencePoints * modifier));
        }

        return result;
    }

    private async Task TryLoadUnlocks()
    {
        _professionUnlocks = await professionUnlockRepository.GetAll();
    }
}
