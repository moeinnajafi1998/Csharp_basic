// Abstraction:
// Abstraction involves creating simple representations of complex systems by focusing on the essential details while hiding the unnecessary complexities.
// In C#, this is achieved using abstract classes and interfaces.
// Abstract classes cannot be instantiated and may contain abstract methods that derived classes must implement.
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


class Program{
    static void Main(string[] Main){
    Shape myCircle = new Circle { Radius = 5 };
    Console.WriteLine(myCircle.GetArea()); // Output: 78.54
    }
}