using FluentAssertions;
namespace fsharp.tests;
public class Case_01_ImminentDanger
{
    [Theory]
    [InlineData("Nobody", 9999, "Rock", 70, "Rock")]
    [InlineData("Nobody", 9999, "HotDroid", 70, "HotDroid")]
    [InlineData("HardHat", 70, "Bolt", 70, "Bolt")]
    [InlineData("Sectoid", 56, "HardHat", 60, "Sectoid")]
    [InlineData("Buzz", 59, "HardHat", 50, "HardHat")]
    [InlineData("Zap", 40, "Buzz", 38, "Buzz")]
    [InlineData("Zap", 20, "Charger", 34, "Zap")]
    [InlineData("Whacker", 36, "Charger", 14, "Charger")]
    [InlineData("Whacker", 14, "MaulMaker", 35, "Whacker")]
    [InlineData("Fuse", 39, "MaulMaker", 16, "MaulMaker")]
    [InlineData("Fuse", 19, "NutCracker", 46, "Fuse")]
    [InlineData("Buster", 32, "NutCracker", 22, "NutCracker")]
    [InlineData("Hitbot", 43, "Buster", 8, "Buster")]
    [InlineData("Hitbot", 26, "DangerDart", 40, "Hitbot")]
    [InlineData("Nobody", 9999, "DangerDart", 35, "DangerDart")]
    public void EnemyWithShortestDistanceInOutput(string enemy1, int dist1, string enemy2, int dist2, string expected)
    {
        // Arrange

        // Act
        var output = OutputGenerator.generate(enemy1, dist1, enemy2, dist2);

        // Asssert
        output.Should().Be(expected);
    }
}
