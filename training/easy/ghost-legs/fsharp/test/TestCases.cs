using FluentAssertions;

namespace fsharp.tests;

public class TestCases
{
    [Fact]
    public void Case_01_SimpleSample()
    {
        // Arrange
        var dimensions = "7 7";
        var board = new string[]
        {
            "A  B  C",
            "|  |  |",
            "|--|  |",
            "|  |--|",
            "|  |--|",
            "|  |  |",
            "1  2  3"
        };

        // Act
        var output = OutputGenerator.generate(dimensions, board);

        // Arrange
        var expected = new string[]
        {
            "A2",
            "B1",
            "C3"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_02_SmallSample()
    {
        // Arrange
        var dimensions = "13 8";
        var board = new string[]
        {
            "A  B  C  D  E",
            "|  |  |  |  |",
            "|  |--|  |  |",
            "|--|  |  |  |",
            "|  |  |--|  |",
            "|  |--|  |--|",
            "|  |  |  |  |",
            "1  2  3  4  5"
        };

        // Act
        var output = OutputGenerator.generate(dimensions, board);

        // Arrange
        var expected = new string[]
        {
            "A3",
            "B5",
            "C1",
            "D2",
            "E4"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_03_6Lanes()
    {
        // Arrange
        var dimensions = "16 14";
        var board = new string[]
        {
            "F  E  D  C  B  A",
            "|  |--|  |  |  |",
            "|--|  |--|  |--|",
            "|  |--|  |--|  |",
            "|  |  |  |  |--|",
            "|  |--|  |--|  |",
            "|  |  |--|  |  |",
            "|  |  |--|  |--|",
            "|--|  |  |--|  |",
            "|  |  |--|  |  |",
            "|--|  |  |  |--|",
            "|  |--|  |  |  |",
            "|  |  |--|  |  |",
            "0  1  2  3  4  5"
        };

        // Act
        var output = OutputGenerator.generate(dimensions, board);

        // Arrange
        var expected = new string[]
        {
            "F3",
            "E1",
            "D0",
            "C2",
            "B5",
            "A4"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_04_8Lanes()
    {
        // Arrange
        var dimensions = "22 18";
        var board = new string[]
        {
            "P  Q  R  S  T  U  V  W",
            "|  |  |  |  |--|  |  |",
            "|  |  |--|  |  |  |--|",
            "|  |--|  |--|  |  |  |",
            "|--|  |--|  |  |  |--|",
            "|--|  |  |  |  |--|  |",
            "|  |--|  |  |--|  |--|",
            "|  |  |  |--|  |--|  |",
            "|--|  |  |  |--|  |  |",
            "|  |  |--|  |  |  |  |",
            "|  |  |  |--|  |  |--|",
            "|  |  |  |  |--|  |  |",
            "|--|  |  |  |  |  |  |",
            "|--|  |--|  |  |  |--|",
            "|  |--|  |  |--|  |  |",
            "|  |  |--|  |  |  |--|",
            "|--|  |--|  |  |--|  |",
            "1  2  3  4  5  6  7  8"
        };

        // Act
        var output = OutputGenerator.generate(dimensions, board);

        // Arrange
        var expected = new string[]
        {
            "P3",
            "Q7",
            "R8",
            "S5",
            "T6",
            "U2",
            "V4",
            "W1"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_05_10Lanes()
    {
        // Arrange
        var dimensions = "28 20";
        var board = new string[]
        {
            "A  B  C  D  E  F  G  H  I  J",
            "|--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |--|  |--|  |",
            "|  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |--|  |--|  |",
            "0  1  2  3  4  5  6  7  8  9"
        };

        // Act
        var output = OutputGenerator.generate(dimensions, board);

        // Arrange
        var expected = new string[]
        {
            "A1",
            "B3",
            "C0",
            "D5",
            "E2",
            "F7",
            "G4",
            "H9",
            "I6",
            "J8"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }

    [Fact]
    public void Case_06_WideAndWild()
    {
        // Arrange
        var dimensions = "76 23";
        var board = new string[]
        {
            @"~  !  @  #  $  %  ^  &  *  (  )  +  `  1  2  3  4  5  6  7  8  9  0  =  \  /",
            "|  |--|  |  |--|  |  |--|  |--|  |  |--|  |  |  |--|  |--|  |  |--|  |  |--|",
            "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |--|  |  |  |--|  |",
            "|  |--|  |--|  |  |  |  |  |--|  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|",
            "|--|  |  |  |  |--|  |  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|  |--|  |",
            "|  |--|  |  |--|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |  |--|  |--|  |",
            "|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |  |--|  |--|  |--|  |--|  |--|",
            "|--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |--|  |  |--|  |--|",
            "|  |  |--|  |  |  |  |--|  |  |--|  |  |  |  |  |  |--|  |  |  |--|  |--|  |",
            "|  |  |  |--|  |  |--|  |  |  |  |--|  |  |--|  |--|  |--|  |--|  |--|  |--|",
            "|  |--|  |--|  |  |  |  |  |--|  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|",
            "|--|  |  |  |  |--|  |  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |  |  |--|  |  |--|",
            "|  |--|  |  |--|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |  |--|  |--|  |",
            "|  |--|  |  |--|  |  |  |  |--|  |  |--|  |  |--|  |--|  |--|  |--|  |--|  |",
            "|--|  |  |--|  |  |  |  |--|  |  |--|  |--|  |  |--|  |--|  |--|  |--|  |--|",
            "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |  |  |--|  |  |--|",
            "|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |--|  |  |--|  |--|  |--|  |--|",
            "|  |  |  |--|  |  |--|  |  |  |  |--|  |  |--|  |  |--|  |--|  |--|  |--|  |",
            "|--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |  |  |  |  |--|",
            "a  A  b  B  c  C  d  D  e  E  f  F  g  G  h  H  i  I  j  J  k  K  l  L  m  M"
        };

        // Act
        var output = OutputGenerator.generate(dimensions, board);

        // Arrange
        var expected = new string[]
        {
            "~E",
            "!F",
            "@C",
            "#c",
            "$G",
            "%B",
            "^A",
            "&h",
            "*a",
            "(g",
            ")b",
            "+f",
            "`I",
            "1d",
            "2D",
            "3i",
            "4J",
            "5e",
            "6M",
            "7k",
            "8L",
            "9l",
            "0H",
            "=K",
            @"\j",
            "/m"
        };
        output.Should().NotBeEmpty()
            .And.HaveCount(expected.Length)
            .And.Equal(expected);
    }
}