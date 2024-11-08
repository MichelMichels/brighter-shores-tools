using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Forager.Services;

namespace BrighterShoresTools.Professions.ForagerTests.Services;

[TestClass()]
public class ForagerCalculatorTests
{
    [TestMethod()]
    public async Task CalculateNumberOfActionsTestAsync()
    {
        // Arrange
        ForagerActionRepository foragerActionLoader = new();
        List<ProfessionAction> actions = await foragerActionLoader.GetAll();

        // Act

        // Assert        
        Assert.Fail();
    }
}

