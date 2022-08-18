using csharp;

string[] inputs = Console.ReadLine()!.Split(' ');
int lightX = int.Parse(inputs[0]); // the X position of the light of power
int lightY = int.Parse(inputs[1]); // the Y position of the light of power
int initialTX = int.Parse(inputs[2]); // Thor's starting X position
int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

int tX = initialTX;
int tY = initialTY;

// game loop
while (tX != lightX || tY != lightY)
{
    int remainingTurns = int.Parse(Console.ReadLine()!); // The remaining amount of turns Thor can move. Do not remove this line.

    // Write an action using Console.WriteLine()
    // To debug: Console.Error.WriteLine("Debug messages...");
    var output = "";

    output = OutputGenerator.Generate(lightX, lightY, tX, tY);

    OutputGenerator.UpdatePosition(ref tX, ref tY, output);

    // A single line providing the move to be made: N NE E SE S SW W or NW
    Console.WriteLine(output);
}
