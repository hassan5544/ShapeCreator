using ShapeCreator;
using ShapeCreator.Shapes;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Shape Name");
        string shapeName = Console.ReadLine();
        Console.WriteLine("Enter Shape data");
        double data =Convert.ToDouble(Console.ReadLine());
        
        IShape SelectedShape =  ShapeFactory.CreateShape(shapeName , data);
        
        SelectedShape.DrawShape();
        Console.WriteLine(SelectedShape.GetArea());

    }
}
