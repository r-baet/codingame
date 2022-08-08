using FluentAssertions;

namespace fsharp.tests;

public class TestCases
{
    [Fact]
    public void Case_01_MovingFreely()
    {
        // Arrange
        var rookPosition = "d5";
        var numberOfPieces = 2;
        var positions = new string[numberOfPieces];
        positions[0] = "0 c1";
        positions[1] = "1 e8";

        // Act
        var output = OutputGenerator.generate(rookPosition, numberOfPieces, positions);

        // Assert
        var expected = new string[]
        {
            "Rd5-a5",
            "Rd5-b5",
            "Rd5-c5",
            "Rd5-d1",
            "Rd5-d2",
            "Rd5-d3",
            "Rd5-d4",
            "Rd5-d6",
            "Rd5-d7",
            "Rd5-d8",
            "Rd5-e5",
            "Rd5-f5",
            "Rd5-g5",
            "Rd5-h5"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }
}