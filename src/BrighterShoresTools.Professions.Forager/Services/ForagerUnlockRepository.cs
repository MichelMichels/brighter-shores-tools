using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerUnlockRepository : ProfessionUnlockRepository, IForagerUnlockRepository
{
    public ForagerUnlockRepository()
    {
        AddUnlock(0, "Brown Kelp", 84);
        AddUnlock(2, "Creamy Wallplant", 67);
        AddUnlock(4, "White Periwinkle", 71);
        AddUnlock(6, "Horn Shell", 100);
        AddUnlock(8, "Piper Potato", 105);
        AddUnlock(10, "Tangled Pond Weed", 84);
        AddUnlock(12, "Mauve Bellplant", 118);
        AddUnlock(14, "Huge Monument Piece", 94);
        AddUnlock(16, "White Water Lily", 133);
        AddUnlock(18, "Wrinkled Starfish", 141);
        AddUnlock(20, "Gray Louse", 9);
        AddUnlock(23, "Hefty Monument Piece", 123);
        AddUnlock(26, "Slippe Sea Slug", 10);
        AddUnlock(29, "Green Hogberries", 184);
    }
}
