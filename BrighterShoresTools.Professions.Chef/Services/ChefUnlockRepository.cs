using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Chef.Services;

public class ChefUnlockRepository : ProfessionUnlockRepository, IChefUnlockRepository
{
    public ChefUnlockRepository()
    {
        AddUnlock(0, "Basic Bacon Sandwich", 67);
        AddUnlock(2, "Lesser Jellied Eels", 69);
        AddUnlock(4, "Basic Omelette", 38);
        AddUnlock(6, "Basic Sausage and Mash", 118);
        AddUnlock(8, "Basic Vegetable Stew", 80);
        AddUnlock(10, "Gray Jellied Eels", 87);
        AddUnlock(12, "Appetizing Bacon Sandwich", 95);
        AddUnlock(14, "Basic Chicken and Leek Pie", 102);
        AddUnlock(16, "Yellowtail Gurnard Soup", 56);
        AddUnlock(18, "Appetizing Sausage and Mash", 167);
        AddUnlock(22, "Rocky Jellied Eels", 122);
        AddUnlock(25, "Appetizing Vegetable Stew", 129);
        AddUnlock(30, "Appetizing Chicken and Leek Pie", 148);
        AddUnlock(32, "Placid Grilled Bass", 78);
        AddUnlock(38, "Fine Bacon Sandwich", 175);
        AddUnlock(43, "Rord Jellied Eels", 179);
        AddUnlock(45, "Appetizing Lobster Thermidor", 287);
        AddUnlock(50, "Common Fried Ray Wings", 106);
        AddUnlock(56, "Fine Chicken and Leek Pie", 253);
        AddUnlock(61, "Bigeye Gurnard Soup", 137);
        AddUnlock(63, "Fine Vegetable Stew", 268);
    }
}
