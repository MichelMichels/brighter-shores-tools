using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerActionRepository : IProfessionUnlockRepository
{
    private static List<ProfessionUnlock> _foragerActions =
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
