namespace fsharp.tests;
public class Case_01_ImminentDanger
{
    [Fact]
    public void EnemyWithShortestDistanceInOutput()
    {
        // Arrange
        var enemy1 = "Nobody";
        var dist1 = 9999;
        var enemy2 = "Rock";
        var dist2 = 70;

        // Act
        var output = OutputGenerator.generate(enemy1, dist1, enemy2, dist2);

        // Asssert
        Assert.Equal("Rock", output);
    }
}
