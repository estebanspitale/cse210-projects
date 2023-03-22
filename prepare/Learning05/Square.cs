using System;

public class Square : Shape
{
    private double _side = 0;
    private string _type = "Square";

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override string GetShapeType()
    {
        return _type;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

}