namespace Laba9_V5;

public class Square : Rectangle
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public override double Area() =>
        Math.Pow(_side, 2);

    public override double Perimeter() =>
        _side * 4;
}