using BrighterShoresTools.Professions.Core.Models;
using BrighterShoresTools.Professions.Core.Services;
using BrighterShoresTools.Professions.Forager.Services;
using NSubstitute;

namespace BrighterShoresTools.Professions.ForagerTests.Services;

[TestClass()]
public class ForagerCalculatorTests
{
    [TestMethod()]
    public async Task CalculateNumberOfActions_500xp_Test()
    {
        // Arrange
        IForagerUnlockRepository foragerUnlockRepository = Substitute.For<IForagerUnlockRepository>();
        foragerUnlockRepository.GetAll().Returns(Task.FromResult(new List<ProfessionUnlock>()
        {
            new(0, "Test unlock", 100)
        }));

        IExperienceCalculator experienceCalculator = Substitute.For<IExperienceCalculator>();
        experienceCalculator.GetExperienceBetweenLevels(Arg.Any<int>(), Arg.Any<int>()).Returns(500);


        ForagerCalculator calculator = new(foragerUnlockRepository, experienceCalculator);

        // Act
        List<ProfessionCalculationResult> results = await calculator.CalculateNumberOfActions(0, 1);

        // Assert        
        Assert.IsNotNull(results);
        Assert.IsTrue(results.Count > 0);
        Assert.AreEqual(5, results.First().NumberOfActions);
    }
}

