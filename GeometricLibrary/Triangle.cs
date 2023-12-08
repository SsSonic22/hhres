namespace Geometric.Library;

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public override double CalculateArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }
    public  bool IsRightTriangle()
    {
        return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
               Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
               Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
    }
}