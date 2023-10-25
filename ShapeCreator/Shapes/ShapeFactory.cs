namespace ShapeCreator.Shapes;

public class ShapeFactory
{
    
    public static IShape CreateShape(string shapeName , double parameter)
    {
        if (shapeName == "Square")
            return new Square(parameter);
        else if (shapeName == "Circle")
            return new Circle(parameter);
        else
        {
            throw new ArgumentException("Shape is not defined");
        }
    }
}