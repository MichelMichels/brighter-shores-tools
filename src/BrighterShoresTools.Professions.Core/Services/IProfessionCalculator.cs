using BrighterShoresTools.Professions.Core.Models;

namespace BrighterShoresTools.Professions.Core.Services;

public interface IProfessionCalculator
{
    Task<Dictionary<ProfessionUnlock, int>> CalculateNumberOfActions(int startLevel, int endLevel, double modifier = 1, bool isOnlyPossibleUnlocks = true);
}
