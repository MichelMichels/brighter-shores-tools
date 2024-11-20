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
    }
}