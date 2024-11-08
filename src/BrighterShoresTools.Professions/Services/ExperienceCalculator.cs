namespace BrighterShoresTools.Professions.Core.Services;

public class ExperienceCalculator : IExperienceCalculator
{
    public int GetExperienceBetweenLevels(int startLevel, int endLevel)
    {
        throw new NotImplementedException();
    }

    public int GetExperienceFromLevel(int level)
    {
        int baseLevel = 500 * level;
        int triangularNumberSequenceModifier = 15 * level * (level - 1) / 2;
        int squareModifier = level - 4 > 0 ? (int)Math.Pow(level - 4, 2) : 0;

        return baseLevel + triangularNumberSequenceModifier + squareModifier;
    }
}
