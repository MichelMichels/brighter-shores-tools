using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerUnlockRepository : IForagerUnlockRepository
{
    private static readonly List<ProfessionUnlock> _foragerActions =
    [
        new(0, "Brown Kelp", 84),
        new(2, "Creamy Wallplant", 67),
        new(4, "White Periwinkle", 71),
        new(6, "Horn Shell", 100),
        new(8, "Piper Potato", 105),
        new(10, "Tangled Pond Weed", 84),
        new(12, "Mauve Bellplant", 118),
        new(14, "Huge Monument Piece", 94),
        new(16, "White Water Lily", 133),
        new(18, "Wrinkled Starfish", 141),
        new(20, "Gray Louse", 9),
        new(23, "Hefty Monument Piece", 123),
        new(26, "Slippe Sea Slug", 10),
        new(29, "Green Hogberries", 184),
    ];

    public Task<List<ProfessionUnlock>> GetAll()
    {
        return Task.FromResult(_foragerActions);
    }

    public Task<ProfessionUnlock?> GetByName(string name)
    {
        ProfessionUnlock? action = _foragerActions.FirstOrDefault(x => x.Name.Equals(name));
        return Task.FromResult(action);
    }
}
