using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.CoreTests.Services;

[TestClass()]
public class ExperienceCalculatorTests
{
    [TestMethod()]
    [DataRow(14, 15, 2997)]
    [DataRow(26, 27, 20000)]
    public void GetExperienceBetweenLevelsTest(int startLevel, int endLevel, int expectedExperience)
    {
        // Arrange
        ExperienceCalculator experienceCalculator = new();

        // Act
        int xp = experienceCalculator.GetExperienceBetweenLevels(startLevel, endLevel);

        // Assert
        Assert.AreEqual(expectedExperience, xp);
    }

    [TestMethod()]
    [DataRow(0, 0)]
    [DataRow(1, 500)]
    [DataRow(2, 1015)]
    [DataRow(3, 1545)]
    [DataRow(4, 2090)]
    [DataRow(5, 2651)]
    [DataRow(6, 3229)]
    [DataRow(7, 4418)]
    [DataRow(9, 6902)]
    [DataRow(11, 9534)]
    [DataRow(14, 16647)]
    [DataRow(15, 19644)]
    public void GetExperienceFromLevelTest(int level, int expectedExperience)
    {
        // Arrange
        ExperienceCalculator experienceCalculator = new();

        // Act
        int xp = experienceCalculator.GetExperienceFromLevel(level);

        // Assert
        Assert.AreEqual(expectedExperience, xp);
    }
}

// guard XP

// goblin = 205 xp

// level 0 - 0      (0)     = 500 * 0 + 15 *  0 + 0
// level 1 - 500    (500)   = 500 * 1 + 15 *  0 + 0
// level 2 - 1015   (515)   = 500 * 2 + 15 *  1 + 0
// level 3 - 1545   (530)   = 500 * 3 + 15 *  3 + 0
// level 4 - 2090   (545)   = 500 * 4 + 15 *  6 + 0
// level 5 - 2651   (561)   = 500 * 5 + 15 * 10 + 1
// level 6 - 3229   (578)   = 500 * 6 + 15 * 15 + 4
// level 7 - 4418   (1189)   = 500 * 7 + 15 * 25 

// 3500 + 375 

// level X -                = 500 * X + 15 * x(x +1) /2