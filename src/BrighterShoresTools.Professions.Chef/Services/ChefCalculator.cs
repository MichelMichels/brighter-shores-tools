using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Chef.Services;

public class ChefCalculator(
    IChefUnlockRepository chefUnlockRepository,
    IExperienceCalculator experienceCalculator)
    : ProfessionCalculator(chefUnlockRepository, experienceCalculator)
{
}
