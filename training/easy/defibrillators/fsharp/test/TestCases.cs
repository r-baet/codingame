using FluentAssertions;
using fsharp.tests.Attributes;

namespace fsharp.tests;

public class TestCases
{
    [Theory]
    [FileData(directoryName: "Input")]
    public void Case_01_Example(string longitude, string latitude, int nrOfDefibrillators, params string[] defibrillators)
    {
        // Arrange

        // Act
        var output = OutputGenerator.generate(longitude, latitude, nrOfDefibrillators, defibrillators);

        // Assert
        output.Should().Be("Maison de la Prevention Sante");
    }
}