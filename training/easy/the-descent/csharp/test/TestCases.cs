using csharp.tests.Attributes;
using FluentAssertions;

namespace csharp.tests;

public class TestCases
{
    [Theory]
    [CsvData]
    public void Case_01_DescendingMountains(
        int height0, int height1, int height2,
        int height3, int height4, int height5,
        int height6, int height7, int expected
        )
    {
        // Arrange

        // Act
        var output = OutputGenerator.Generate(height0, height1, height2, height3, height4, height5, height6, height7);

        // Asssert
        output.Should().BeAssignableTo(typeof(int))
            .And.Be("" + expected);
    }
}