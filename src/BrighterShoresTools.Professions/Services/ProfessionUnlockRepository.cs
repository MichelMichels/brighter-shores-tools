using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Core.Services;

public abstract class ProfessionUnlockRepository : IProfessionUnlockRepository
{
    protected List<ProfessionUnlock> _unlocks = [];

    public Task<List<ProfessionUnlock>> GetAll()
    {
        return Task.FromResult(_unlocks);
    }

    public Task<ProfessionUnlock?> GetByName(string name)
    {
        ProfessionUnlock? action = _unlocks.FirstOrDefault(x => x.Name.Equals(name));
        return Task.FromResult(action);
    }

    protected void AddUnlock(int level, string name, int experiencePoints)
    {
        _unlocks.Add(new ProfessionUnlock(level, name, experiencePoints));
    }
}
