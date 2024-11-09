using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerCalculator(
    IForagerUnlockRepository foragerUnlockRepository,
    IExperienceCalculator experienceCalculator)
    : ProfessionCalculator(foragerUnlockRepository, experienceCalculator)
{
}
