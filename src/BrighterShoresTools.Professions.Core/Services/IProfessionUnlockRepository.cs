using BrighterShoresTools.Professions.Core.Models;

namespace BrighterShoresTools.Professions.Core.Services;

public interface IProfessionUnlockRepository
{
    Task<List<ProfessionUnlock>> GetAll();
    Task<ProfessionUnlock?> GetByName(string name);
}
