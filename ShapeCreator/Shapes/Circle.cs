namespace ShapeCreator.Shapes;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public void DrawShape()
    {
        Console.WriteLine("Drawing Circle");
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}