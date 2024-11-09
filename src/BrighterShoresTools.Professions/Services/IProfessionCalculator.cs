using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Core.Services;

public interface IProfessionCalculator
{
    Dictionary<ProfessionUnlock, int> CalculateNumberOfActions(int startLevel, int endLevel);
}
