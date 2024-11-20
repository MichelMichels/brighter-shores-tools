using BrighterShoresTools.Episodes.Core.Models;

namespace BrighterShoresTools.Episodes.Core.Services;

public interface IEpisodeRepository
{
    Task<List<Episode>> GetAll();
    Task<Episode> GetById(int id);
    Task<Episode> GetByName(string name);
}
