using FluentAssertions;

namespace fsharp.tests;

public class TestCases
{
    [Fact]
    public void Case_01_Test20()
    {
        // Arrange
        var meetingPoint = 20;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("NO");
    }

    [Fact]
    public void Case_02_TheLucky13()
    {
        // Arrange
        var meetingPoint = 13;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("YES");
    }

    [Fact]
    public void Case_03_yyy()
    {
        // Arrange
        var meetingPoint = 984;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("NO");
    }

    [Fact]
    public void Case_04_zzzz()
    {
        // Arrange
        var meetingPoint = 1006;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("NO");
    }

    [Fact]
    public void Case_05_YesPlease()
    {
        // Arrange
        var meetingPoint = 9915;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("YES");
    }

    [Fact]
    public void Case_06_4aaaa()
    {
        // Arrange
        var meetingPoint = 42406;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("NO");
    }

    [Fact]
    public void Case_07_BIG()
    {
        // Arrange
        var meetingPoint = 91004;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("NO");
    }

    [Fact]
    public void Case_08_MaybeYesThisTime()
    {
        // Arrange
        var meetingPoint = 90000;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("YES");
    }

    [Fact]
    public void Case_09_RandomNumberOne()
    {
        // Arrange
        var meetingPoint = 15623;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("YES");
    }

    [Fact]
    public void Case_10_RandomNumberTwo()
    {
        // Arrange
        var meetingPoint = 11145;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("NO");
    }

    [Fact]
    public void Case_11_RandomLarge()
    {
        // Arrange
        var meetingPoint = 89696;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("YES");
    }

    [Fact]
    public void Case_12_RandomSmall()
    {
        // Arrange
        var meetingPoint = 80;

        // Act
        var output = OutputGenerator.generate(meetingPoint);

        // Assert
        output.Should().Be("YES");
    }
}