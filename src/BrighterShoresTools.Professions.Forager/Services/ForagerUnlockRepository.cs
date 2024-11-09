using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerUnlockRepository : IForagerUnlockRepository
{
    private static readonly List<ProfessionUnlock> _foragerActions =
        [
            new() {
                Name = "Mauve Bellplant",
                StartingLevel = 12,
                ExperiencePoints = 118
            }
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
