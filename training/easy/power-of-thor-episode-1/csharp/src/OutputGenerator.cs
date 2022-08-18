namespace csharp;

public static class OutputGenerator
{
    public static string Generate(int lightX, int lightY, int tX, int tY)
    {
        var output = "";

        if (tY > lightY)
        {
            output += "N";
        }
        else if (tY < lightY)
        {
            output += "S";
        }
        if (tX > lightX)
        {
            tX--;
            output += "W";
        }
        else if (tX < lightX)
        {
            tX++;
            output += "E";
        }

        return output;
    }

    public static void UpdatePosition(ref int tX, ref int tY, string movement)
    {
        if (movement.Contains('N'))
        {
            tY--;
        }
        else if (movement.Contains('S'))
        {
            tY++;
        }
        if (movement.Contains('W'))
        {
            tX--;
        }
        else if (movement.Contains('E'))
        {
            tX++;
        }
    }
}
