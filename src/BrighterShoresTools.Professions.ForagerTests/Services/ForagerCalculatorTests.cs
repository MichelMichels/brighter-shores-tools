using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;
using BrighterShoresTools.Professions.Forager.Services;
using NSubstitute;

namespace BrighterShoresTools.Professions.ForagerTests.Services;

[TestClass()]
public class ForagerCalculatorTests
{
    [TestMethod()]
    public async Task CalculateNumberOfActionsTestAsync()
    {
        // Arrange
        ForagerCalculator calculator = new(Substitute.For<IProfessionUnlockRepository>(), Substitute.For<IExperienceCalculator>());

        // Act
        Dictionary<ProfessionUnlock, int> result = await calculator.CalculateNumberOfActions(0, 1);

        // Assert        
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Count > 0);
    }
}

