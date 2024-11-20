using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Alchemist.Services;

public class AlchemistUnlockRepository : ProfessionUnlockRepository, IAlchemistUnlockRepository
{
    public AlchemistUnlockRepository()
    {
        AddUnlock(0, "10% Healing Potion", 105);
        AddUnlock(2, "20% Healing Potion", 112);
        AddUnlock(4, "5% Potion - XP Hopeport", 118);
        AddUnlock(6, "+40 Potion - Strength Arborae", 125);
        AddUnlock(8, "+40 Potion - Strength Cryonae", 132);
        AddUnlock(10, "+40 Potion - Strength Tempestae", 140);
        AddUnlock(12, "3 Minute Potion - Fear", 148);
        AddUnlock(14, "5% Potion - XP Hopeforest", 157);
        AddUnlock(16, "5% Potion - XP Mine", 167);
        AddUnlock(18, "5% Potion - XP Crenopolis", 177);
        AddUnlock(23, "5% Potion - XP Stonemaw Hill", 205);
        AddUnlock(29, "25% Potion - Healing", 230);
        AddUnlock(35, "28% Potent Potion - Healing", 556);
        AddUnlock(41, "6% Potion - XP Hopeport", 302);
        AddUnlock(50, "7% Potent Potion - XP Hopeport", 743);
        AddUnlock(56, "+50 Potion - Strength Arborae", 387);
        AddUnlock(62, "+60 Potent Potion - Strength Arborae", 936);
        AddUnlock(68, "+50 Potion - Strength Cryonae", 507);
        AddUnlock(77, "+60 Potent Potion - Strength Cryonae", 1249);
        AddUnlock(83, "+50 Potion - Strength Tempestae", 650);
        AddUnlock(89, "+60 Potent Potion - Strength Tempestae", 1574);
        AddUnlock(95, "6 Minute Potion - Fear", 850);
        AddUnlock(104, "9 Minute Potion - Fear", 2100);
        AddUnlock(110, "6% Potion - XP Hopeforest", 1092);
    }
}