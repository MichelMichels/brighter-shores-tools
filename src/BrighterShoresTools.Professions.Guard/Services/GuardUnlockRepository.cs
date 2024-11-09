using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Guard.Services;

public class GuardUnlockRepository : IProfessionUnlockRepository
{
    private static readonly List<ProfessionUnlock> _guardUnlocks =
        [
            new() {
                Name = "Sparring Guard",
                StartingLevel = 0,
                ExperiencePoints = 205
            }
        ];

    public Task<List<ProfessionUnlock>> GetAll()
    {
        return Task.FromResult(_guardUnlocks);
    }

    public Task<ProfessionUnlock?> GetByName(string name)
    {
        ProfessionUnlock? action = _guardUnlocks.FirstOrDefault(x => x.Name.Equals(name));
        return Task.FromResult(action);
    }
}
