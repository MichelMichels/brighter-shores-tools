using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerCalculator(
    IProfessionUnlockRepository professionUnlockRepository,
    IExperienceCalculator experienceCalculator) : IProfessionCalculator
{
    private readonly IProfessionUnlockRepository professionUnlockRepository = professionUnlockRepository ?? throw new ArgumentNullException(nameof(professionUnlockRepository));
    private readonly IExperienceCalculator experienceCalculator = experienceCalculator ?? throw new ArgumentNullException(nameof(experienceCalculator));

    private static List<ProfessionUnlock> _professionUnlocks = [];

    public async Task<Dictionary<ProfessionUnlock, int>> CalculateNumberOfActions(int startLevel, int endLevel)
    {
        await TryLoadUnlocks();

        throw new NotImplementedException();
    }

    private async Task TryLoadUnlocks()
    {
        _professionUnlocks = await professionUnlockRepository.GetAll();
    }
}
