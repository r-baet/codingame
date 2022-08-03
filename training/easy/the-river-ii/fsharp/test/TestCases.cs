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
}