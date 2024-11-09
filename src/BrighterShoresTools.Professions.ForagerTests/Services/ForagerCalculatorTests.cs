using BrighterShoresTools.Professions.Core.Data;
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
            new() {
                ExperiencePoints = 100,
                Name = "Test unlock",
                StartingLevel = 0
            }
        }));

        IExperienceCalculator experienceCalculator = Substitute.For<IExperienceCalculator>();
        experienceCalculator.GetExperienceBetweenLevels(Arg.Any<int>(), Arg.Any<int>()).Returns(500);


        ForagerCalculator calculator = new(foragerUnlockRepository, experienceCalculator);

        // Act
        Dictionary<ProfessionUnlock, int> result = await calculator.CalculateNumberOfActions(0, 1);

        // Assert        
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Count > 0);
        Assert.AreEqual(5, result.First().Value);
    }
}

