using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Core.Services;

public interface IProfessionActionRepository
{
    Task<List<ProfessionAction>> GetAll();
    Task<ProfessionAction?> GetByName(string name);
}
