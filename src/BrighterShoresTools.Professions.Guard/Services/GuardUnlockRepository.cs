using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Guard.Services;

public class GuardUnlockRepository : ProfessionUnlockRepository, IGuardUnlockRepository
{
    public GuardUnlockRepository()
    {
        AddUnlock(0, "Recruit Sparring Guard", 205);
        AddUnlock(0, "Glinteye Deathcrow", 221);
        AddUnlock(0, "Common Thief", 238);
        AddUnlock(0, "Looter Goblin Soldier", 256);
        AddUnlock(0, "Irritable Goblin Chief", 276);
        AddUnlock(0, "Feral Hairbeast", 297);
        AddUnlock(0, "Greenlid Carnivorous Plant", 319);
        AddUnlock(0, "Shambling Ghoul", 343);
        AddUnlock(10, "Beady-eyed Deathcrow", 369);
        AddUnlock(12, "Rookie Sparring Guard", 397);
        AddUnlock(14, "Scruffy Thief", 468);
        AddUnlock(16, "Hooligan Goblin Soldier", 548);
        AddUnlock(18, "Tangled Hairbeast", 637);
        AddUnlock(20, "Creepy Street Louse", 12);
        AddUnlock(22, "Bossy Goblin Chief", 768);
        AddUnlock(25, "Back Alley Thug", 10);
        AddUnlock(28, "Snap Carnivorous", 895);
        AddUnlock(30, "Pearlcap Crab", 16);
        AddUnlock(33, "Foraging Ghoul", 1039);
        AddUnlock(36, "Primitive Bugman", 19);
        AddUnlock(39, "Tiderider Jellyfish", 20);
        AddUnlock(41, "Wily Deathcrow", 1243);
    }
}
