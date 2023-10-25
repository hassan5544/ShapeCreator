namespace ShapeCreator.Shapes;

public class Square : IShape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }
    
    public void DrawShape()
    {
        Console.WriteLine("Drawing Square");
    }

    public double GetArea()
    {
        return SideLength * SideLength;
    }
}