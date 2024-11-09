namespace BrighterShoresTools.Professions.Core.Services;

public class ExperienceCalculator : IExperienceCalculator
{
    private readonly static Dictionary<int, int> experienceByLevel = new()
    {
        { 0 , 0 },
        { 1 , 500 },
        { 2 , 1015 },
        { 3 , 1545 },
        { 4 , 2090 },
        { 5 , 2651 },
        { 6 , 3229 },
        { 7 , 4418 },
        { 8 , 0 },
        { 9 , 6902 },
        { 10 , 0 },
        { 11 , 9534 },
        { 12 , 0 },
        { 13 , 13736 },
        { 14 , 16647 },
        { 15 , 19644 },
        { 16 , 0 },
        { 17 , 0 },
        { 18 , 0 },
        { 19 , 0 },
        { 20 , 53815 },
    };

    public int GetExperienceBetweenLevels(int startLevel, int goalLevel)
    {
        throw new NotImplementedException();
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
