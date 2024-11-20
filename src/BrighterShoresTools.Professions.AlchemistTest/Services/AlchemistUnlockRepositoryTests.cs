using BrighterShoresTools.Professions.Alchemist.Services;
using BrighterShoresTools.Professions.Core.Models;

namespace BrighterShoresTools.Professions.AlchemistTests.Services;

[TestClass()]
public class AlchemistUnlockRepositoryTests
{
    [TestMethod()]
    public async Task GetAllTestAsync()
    {
        // Arrange
        AlchemistUnlockRepository repository = new();

        // Act
        List<ProfessionUnlock> actions = await repository.GetAll();

        // Assert
        Assert.IsNotNull(actions);
        Assert.IsTrue(actions.Count > 0);
    }

    [TestMethod()]
    public async Task GetByName_Forty_Potion_Strength_Arborae()
    {
        // Arrange
        AlchemistUnlockRepository repository = new();

        // Act
        ProfessionUnlock? action = await repository.GetByName("+40 Potion - Strength Arborae");

        // Assert
        Assert.IsNotNull(action);
        Assert.AreEqual("+40 Potion - Strength Arborae", action.Name);
        Assert.AreEqual(6, action.Level);
        Assert.AreEqual(125, action.ExperiencePoints);
    }
}