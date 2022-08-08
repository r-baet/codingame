namespace fsharp.tests
{
    [UsesVerify]
    public class TestCasesVerify
    {
        [Fact]
        public Task Case_01_SimpleSample()
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
            return Verify(output).UseDirectory("Approvals");
        }
    }
}
