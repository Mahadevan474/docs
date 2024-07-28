using System;

namespace Keywords;
//<snippet15>
interface IPoint
{
    // Property signatures:
    int X { get; set; }

    int Y { get; set; }

    double Distance { get; }
}

class Point : IPoint
{
    // Constructor:
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Property implementation:
    public int X { get; set; }

    public int Y { get; set; }

    // Property implementation
    public double Distance =>
       Math.Sqrt(X * X + Y * Y);
}

class MainClass
{
    static void PrintPointDetails(IPoint p)
    {
        // Print the coordinates of the point and the distance from the origin
        Console.WriteLine("x={0}, y={1}, distance={2}", p.X, p.Y, p.Distance);
    }
    
    static void Main()
    {
        IPoint p = new Point(2, 3);
        Console.Write("My Point: ");
        PrintPointDetails(point);
    }
}
// Output: My Point: x=2, y=3, distance=3.605551275463989
//</snippet15>
