using System;

public class Circle : Shape
{
    private double _radius = 0;
    private const double PI = 3.14;
    private string _type = "Circle";
    
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    
    public override double GetArea()
    {
        return Math.Round(PI * (_radius * _radius), 2);
    }

    public override string GetShapeType()
    {
        return _type;
    }

}