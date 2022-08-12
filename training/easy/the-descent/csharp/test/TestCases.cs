using csharp.tests.Attributes;
using FluentAssertions;

namespace csharp.tests;

public class TestCases
{
    [Theory]
    [CsvData(fileName: nameof(Case_01_DescendingMountains), hasHeaders: true)]
    public void Case_01_DescendingMountains(int expected, params int[] heights)
    {
        // Arrange

        // Act
        var output = OutputGenerator.Generate(heights);

        // Asssert
        int.Parse(output).Should().BeInRange(0, 7, "there are only eight mountains");
        output.Should().Be("" + expected);
    }
}