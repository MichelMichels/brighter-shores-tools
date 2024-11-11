using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Fisher.Services;

public class FisherUnlockRepository : ProfessionUnlockRepository, IFisherUnlockRepository
{
    public FisherUnlockRepository()
    {
        AddUnlock(0, "Mottled Flounder", 63);
        AddUnlock(2, "Lesser Eel", 67);
        AddUnlock(4, "Sandy Pufferfish", 71);
        AddUnlock(6, "Olive Flounder", 75);
        AddUnlock(8, "Gray Eel", 79);
        AddUnlock(10, "Lonely Pufferfish", 83);
        AddUnlock(12, "Stone Flounder", 88);
        AddUnlock(14, "Yellowtail Gurnard", 92);
        AddUnlock(16, "Rocky Eel", 97);
        AddUnlock(18, "Lemon Pufferfish", 102);
        AddUnlock(20, "Common Dab", 9);
        AddUnlock(22, "Arrowtooth Flounder", 115);
        AddUnlock(25, "Spotted Mackibut", 10);
        AddUnlock(28, "Placid Bass", 165);
        AddUnlock(31, "Ballan Wraddock", 11);
        AddUnlock(34, "Ridged Herring", 11);
        AddUnlock(36, "Rord Eel", 148);
        AddUnlock(39, "Orange Lobster", 3212);
        AddUnlock(42, "Figure Eight Pufferfish", 168);
        AddUnlock(45, "Idle Sturlet", 14);
        //AddUnlock(48, "Leathery Bream", );
        AddUnlock(50, "Common Ray", 189);
        //AddUnlock(53, "Small Dab", );
        AddUnlock(56, "Bigeye Gurnard", 210);
    }
}
