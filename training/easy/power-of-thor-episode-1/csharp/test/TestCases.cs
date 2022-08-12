using FluentAssertions;

namespace csharp.tests;

public class TestCases
{
    [Fact]
    public void Case_01_StraightLine()
    {
        // Arrange
        var lightX = 31;
        var lightY = 4;
        var initialTX = 5;
        var initialTY = 4;
        var tX = initialTX;
        var tY = initialTY;
        var remainingEnergy = 100;

        // Act
        while (tX != lightX || tY != lightY)
        {
            string? movement = OutputGenerator.Generate(lightX, lightY, tX, tY);
            OutputGenerator.UpdatePosition(ref tX, ref tY, movement);
            remainingEnergy--;
        }

        // Assert
        remainingEnergy.Should().Be(74);
    }

    [Fact]
    public void Case_02_Up()
    {
        // Arrange
        var lightX = 31;
        var lightY = 4;
        var initialTX = 31;
        var initialTY = 17;
        var tX = initialTX;
        var tY = initialTY;
        var remainingEnergy = 13;

        // Act
        while (tX != lightX || tY != lightY)
        {
            string? movement = OutputGenerator.Generate(lightX, lightY, tX, tY);
            OutputGenerator.UpdatePosition(ref tX, ref tY, movement);
            remainingEnergy--;
        }

        // Assert
        remainingEnergy.Should().Be(0);
    }

    [Fact]
    public void Case_03_EasyAngle()
    {
        // Arrange
        var lightX = 0;
        var lightY = 17;
        var initialTX = 31;
        var initialTY = 4;
        var tX = initialTX;
        var tY = initialTY;
        var remainingEnergy = 44;

        // Act
        while (tX != lightX || tY != lightY)
        {
            string? movement = OutputGenerator.Generate(lightX, lightY, tX, tY);
            OutputGenerator.UpdatePosition(ref tX, ref tY, movement);
            remainingEnergy--;
        }

        // Assert
        remainingEnergy.Should().Be(13);
    }

    [Fact]
    public void Case_04_OptimalAngle()
    {
        // Arrange
        var lightX = 36;
        var lightY = 17;
        var initialTX = 0;
        var initialTY = 0;
        var tX = initialTX;
        var tY = initialTY;
        var remainingEnergy = 36;

        // Act
        while (tX != lightX || tY != lightY)
        {
            string? movement = OutputGenerator.Generate(lightX, lightY, tX, tY);
            OutputGenerator.UpdatePosition(ref tX, ref tY, movement);
            remainingEnergy--;
        }

        // Assert
        remainingEnergy.Should().Be(0);
    }
}