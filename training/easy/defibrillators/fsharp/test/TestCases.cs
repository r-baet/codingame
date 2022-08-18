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

    [Theory]
    [FileData(directoryName: "Input")]
    public void Case_02_ExactPosition(string longitude, string latitude, int nrOfDefibrillators, params string[] defibrillators)
    {
        // Arrange

        // Act
        var output = OutputGenerator.generate(longitude, latitude, nrOfDefibrillators, defibrillators);

        // Assert
        output.Should().Be("Cimetiere Saint-Etienne");
    }

    [Theory]
    [FileData(directoryName: "Input")]
    public void Case_03_CompleteFile(string longitude, string latitude, int nrOfDefibrillators, params string[] defibrillators)
    {
        // Arrange

        // Act
        var output = OutputGenerator.generate(longitude, latitude, nrOfDefibrillators, defibrillators);

        // Assert
        output.Should().Be("Caisse Primaire d'Assurance Maladie");
    }

    [Theory]
    [FileData(directoryName: "Input")]
    public void Case_04_CompleteFile2(string longitude, string latitude, int nrOfDefibrillators, params string[] defibrillators)
    {
        // Arrange

        // Act
        var output = OutputGenerator.generate(longitude, latitude, nrOfDefibrillators, defibrillators);

        // Assert
        output.Should().Be("Amphitheatre d'O");
    }
}