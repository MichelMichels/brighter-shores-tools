using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Forager.Services;

namespace BrighterShoresTools.Professions.ForagerTests.Services;

[TestClass()]
public class ForagerUnlockRepositoryTests
{
    [TestMethod()]
    public async Task GetAllTestAsync()
    {
        // Arrange
        ForagerUnlockRepository repository = new();

        // Act
        List<ProfessionUnlock> actions = await repository.GetAll();

        // Assert
        Assert.IsNotNull(actions);
        Assert.IsTrue(actions.Count > 0);
    }

    [TestMethod()]
    public async Task GetByName_Mauve_Bellplant_Test()
    {
        // Arrange
        ForagerUnlockRepository repository = new();

        // Act
        ProfessionUnlock? action = await repository.GetByName("Mauve Bellplant");

        // Assert
        Assert.IsNotNull(action);
        Assert.AreEqual("Mauve Bellplant", action.Name);
        Assert.AreEqual(12, action.StartingLevel);
        Assert.AreEqual(118, action.ExperiencePoints);
    }
}