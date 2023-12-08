namespace Geometric.Library;

public class Circle : Shape
{
    public double Radius;
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}