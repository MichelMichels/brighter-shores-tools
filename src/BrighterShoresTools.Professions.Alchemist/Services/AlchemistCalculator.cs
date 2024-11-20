using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Alchemist.Services;

public class AlchemistCalculator(IAlchemistUnlockRepository alchemistUnlockRepository, IExperienceCalculator experienceCalculator)
    : ProfessionCalculator(alchemistUnlockRepository, experienceCalculator)
{
}