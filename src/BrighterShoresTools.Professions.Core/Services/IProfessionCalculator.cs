using BrighterShoresTools.Professions.Core.Models;

namespace BrighterShoresTools.Professions.Core.Services;

public interface IProfessionCalculator
{
    Task<List<ProfessionCalculationResult>> CalculateNumberOfActions(int startLevel, int endLevel, double modifier = 1, bool isOnlyPossibleUnlocks = true);
}
