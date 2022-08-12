using csharp;

// game loop
while (true)
{
    var arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
        arr[i] = mountainH;
    }

    var output = OutputGenerator.Generate(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]);

    Console.WriteLine(output); // The index of the mountain to fire on.

}
