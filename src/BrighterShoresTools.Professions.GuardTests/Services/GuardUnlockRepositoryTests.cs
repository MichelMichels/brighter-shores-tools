using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Guard.Services;

namespace BrighterShoresTools.Professions.GuardTests.Services;

[TestClass()]
public class GuardUnlockRepositoryTests
{
    [TestMethod()]
    public async Task GetAllTestAsync()
    {
        // Arrange
        GuardUnlockRepository repository = new();

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
        GuardUnlockRepository repository = new();

        // Act
        ProfessionUnlock? action = await repository.GetByName("Sparring Guard");

        // Assert
        Assert.IsNotNull(action);
        Assert.AreEqual("Sparring Guard", action.Name);
        Assert.AreEqual(0, action.Level);
        Assert.AreEqual(205, action.ExperiencePoints);
    }
}