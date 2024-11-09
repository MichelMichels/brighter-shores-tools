
using BrighterShoresTools.Professions.Core.Data;

namespace BrighterShoresTools.Professions.Forager.Services.Tests;

[TestClass()]
public class ForagerActionRepositoryTests
{
    [TestMethod()]
    public async Task GetAllTestAsync()
    {
        // Arrange
        ForagerActionRepository repository = new();

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
        ForagerActionRepository repository = new();

        // Act
        ProfessionUnlock? action = await repository.GetByName("Mauve Bellplant");

        // Assert
        Assert.IsNotNull(action);
        Assert.AreEqual("Mauve Bellplant", action.Name);
        Assert.AreEqual(12, action.StartingLevel);
        Assert.AreEqual(118, action.ExperiencePoints);
    }
}