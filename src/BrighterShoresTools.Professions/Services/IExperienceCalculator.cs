namespace BrighterShoresTools.Professions.Core.Services;

public interface IExperienceCalculator
{
    int GetExperienceFromLevel(int level);
    int GetExperienceBetweenLevels(int startLevel, int endLevel);
}
