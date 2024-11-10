using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Guard.Services;

public class GuardUnlockRepository : ProfessionUnlockRepository, IGuardUnlockRepository
{
    public GuardUnlockRepository()
    {
        AddUnlock(0, "Sparring Guard", 205);
    }
}
