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

    [Fact]
    public void Case_02_CloseToTheEdge()
    {
        // Arrange
        var rookPosition = "a8";
        var numberOfPieces = 5;
        var positions = new string[numberOfPieces];
        positions[0] = "0 e8";
        positions[1] = "1 d7";
        positions[2] = "0 c6";
        positions[3] = "1 b5";
        positions[4] = "0 a4";

        // Act
        var output = OutputGenerator.generate(rookPosition, numberOfPieces, positions);

        // Assert
        var expected = new string[]
        {
            "Ra8-a5",
            "Ra8-a6",
            "Ra8-a7",
            "Ra8-b8",
            "Ra8-c8",
            "Ra8-d8"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_03_OnlyAllies()
    {
        // Arrange
        var rookPosition = "d5";
        var numberOfPieces = 2;
        var positions = new string[numberOfPieces];
        positions[0] = "0 g5";
        positions[1] = "0 d2";

        // Act
        var output = OutputGenerator.generate(rookPosition, numberOfPieces, positions);

        // Assert
        var expected = new string[]
        {
            "Rd5-a5",
            "Rd5-b5",
            "Rd5-c5",
            "Rd5-d3",
            "Rd5-d4",
            "Rd5-d6",
            "Rd5-d7",
            "Rd5-d8",
            "Rd5-e5",
            "Rd5-f5"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_04_ForFrodooo()
    {
        // Arrange
        var rookPosition = "d5";
        var numberOfPieces = 3;
        var positions = new string[numberOfPieces];
        positions[0] = "0 g5";
        positions[1] = "0 d2";
        positions[2] = "1 d7";

        // Act
        var output = OutputGenerator.generate(rookPosition, numberOfPieces, positions);

        // Assert
        var expected = new string[]
        {
            "Rd5-a5",
            "Rd5-b5",
            "Rd5-c5",
            "Rd5-d3",
            "Rd5-d4",
            "Rd5-d6",
            "Rd5-e5",
            "Rd5-f5",
            "Rd5xd7"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }
}