using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Fisher.Services;

public class FisherCalculator(IFisherUnlockRepository fisherUnlockRepository, IExperienceCalculator experienceCalculator)
    : ProfessionCalculator(fisherUnlockRepository, experienceCalculator)
{
}
