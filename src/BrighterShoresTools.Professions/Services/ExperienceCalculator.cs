namespace BrighterShoresTools.Professions.Core.Services;

public class ExperienceCalculator : IExperienceCalculator
{
    private readonly static int[] experienceByLevel = new int[500];

    public ExperienceCalculator()
    {
        InitializeExperienceByLevelData();
    }

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

    private static void InitializeExperienceByLevelData()
    {
        experienceByLevel[0] = 0;
        experienceByLevel[1] = 500;
        experienceByLevel[2] = 1015;
        experienceByLevel[3] = 1545;
        experienceByLevel[4] = 2090;
        experienceByLevel[5] = 2651;
        experienceByLevel[6] = 3229;
        experienceByLevel[7] = 4418;
        experienceByLevel[8] = 5642;
        experienceByLevel[9] = 6902;
        experienceByLevel[10] = 8199;
        experienceByLevel[11] = 9534;
        experienceByLevel[12] = 10908;
        experienceByLevel[13] = 13736;
        experienceByLevel[14] = 16647;
        experienceByLevel[15] = 19644;
        experienceByLevel[16] = 22728;
        experienceByLevel[17] = 25903;
        experienceByLevel[18] = 29171;
        experienceByLevel[19] = 32535;
        experienceByLevel[20] = 35997;
        experienceByLevel[21] = 53815;
        experienceByLevel[22] = 71979;
        experienceByLevel[23] = 90496;
        experienceByLevel[24] = 109373;
        experienceByLevel[25] = 128617;
        experienceByLevel[26] = 148236;
        experienceByLevel[27] = 168236;
        experienceByLevel[28] = 188625;
        experienceByLevel[29] = 209410;
        experienceByLevel[30] = 230599;
        experienceByLevel[31] = 252200;
        experienceByLevel[32] = 274221;
        experienceByLevel[33] = 296670;
        experienceByLevel[34] = 319556;
        experienceByLevel[35] = 342887;
        experienceByLevel[36] = 366671;
        experienceByLevel[37] = 390918;
        experienceByLevel[38] = 415636;
        experienceByLevel[39] = 440834;
        experienceByLevel[40] = 466522;
        experienceByLevel[41] = 492710;
        experienceByLevel[42] = 519407;
        experienceByLevel[43] = 546623;
        experienceByLevel[44] = 574368;
        experienceByLevel[45] = 602652;
        experienceByLevel[46] = 631486;
        experienceByLevel[47] = 660881;
        experienceByLevel[48] = 690847;
        experienceByLevel[49] = 721396;
        experienceByLevel[50] = 752539;
    }
}
