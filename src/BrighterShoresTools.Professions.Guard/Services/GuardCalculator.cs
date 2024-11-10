using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Guard.Services;

public class GuardCalculator(
    IGuardUnlockRepository guardUnlockRepository,
    IExperienceCalculator experienceCalculator)
    : ProfessionCalculator(guardUnlockRepository, experienceCalculator)
{
}
