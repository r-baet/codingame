using FluentAssertions;

namespace fsharp.tests;

public class TestCases
{
    [Fact]
    public void Case_01_WeWillMeetAt47()
    {
        // Arrange
        var river1 = 32;
        var river2 = 47;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("47");
    }

    [Fact]
    public void Case_02_River1SmallerThanRiver2()
    {
        // Arrange
        var river1 = 57;
        var river2 = 78;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("111");
    }

    [Fact]
    public void Case_03_River1BiggerThanRiver2()
    {
        // Arrange
        var river1 = 7;
        var river2 = 5;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("620");
    }

    [Fact]
    public void Case_04_MoreThan_PartOne()
    {
        // Arrange
        var river1 = 483;
        var river2 = 456;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("483");
    }

    [Fact]
    public void Case_05_MoreThan_PartTwo()
    {
        // Arrange
        var river1 = 1158;
        var river2 = 2085;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("2103");
    }

    [Fact]
    public void Case_06_River2489()
    {
        // Arrange
        var river1 = 5026;
        var river2 = 2489;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("5215");
    }

    [Fact]
    public void Case_07_River13()
    {
        // Arrange
        var river1 = 13;
        var river2 = 14689;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("20014");
    }

    [Fact]
    public void Case_08_Primes()
    {
        // Arrange
        var river1 = 991;
        var river2 = 997;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("1118");
    }

    [Fact]
    public void Case_09_EvenBigger()
    {
        // Arrange
        var river1 = 15485863;
        var river2 = 13000000;

        // Act
        var output = OutputGenerator.generate(river1, river2);

        // Assert
        output.Should().Be("15490633");
    }
}