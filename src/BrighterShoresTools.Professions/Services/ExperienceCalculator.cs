namespace BrighterShoresTools.Professions.Core.Services;

public class ExperienceCalculator : IExperienceCalculator
{
    private readonly static List<int> experienceByLevel = [
        0,
        500,
        1015,
        1545,
        2090,
        2651,
        3229,
        4418,
        5642,
        6902,
        8199,
        9534,
        10908,
        13736,
        16647,
        19644,
        22728,
        25903,
        29171,
        32535,
        35997,
        53815,
        71979,
        90496,
        109373,
        128617,
        148236,
        168236,
        188625,
        209410,
    ];
    public int GetExperienceBetweenLevels(int startLevel, int goalLevel)
    {
        return experienceByLevel[goalLevel] - experienceByLevel[startLevel];
    }

    public int GetExperienceFromLevel(int level)
    {
        return GetExperienceFromDictionary(level);
    }

    private static int CalculateExperienceLevel(int level)
    {
        int baseLevel = 500 * level;
        int triangularNumberSequenceModifier = 15 * level * (level - 1) / 2;
        int squareModifier = level - 4 > 0 ? (int)Math.Pow(level - 4, 2) : 0;

        return baseLevel + triangularNumberSequenceModifier + squareModifier;
    }

    private static int GetExperienceFromDictionary(int level)
    {
        return experienceByLevel[level];
    }
}
