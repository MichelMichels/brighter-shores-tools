using BrighterShoresTools.Professions.Core.Models;
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
    public async Task GetByName_Recruit_Sparring_Guard_Test()
    {
        // Arrange
        GuardUnlockRepository repository = new();

        // Act
        ProfessionUnlock? action = await repository.GetByName("Recruit Sparring Guard");

        // Assert
        Assert.IsNotNull(action);
        Assert.AreEqual("Recruit Sparring Guard", action.Name);
        Assert.AreEqual(0, action.Level);
        Assert.AreEqual(205, action.ExperiencePoints);
    }
}