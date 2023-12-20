namespace Laba9_V5;

public class Rectangle : TQuadrangle
{
    private double _firstSide;
    private double _secondSide;

    public Rectangle(){ }
    public Rectangle(double firstSide, double secondSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
    }
    public override double Area() =>
        _firstSide * _secondSide;

    public override double Perimeter() =>
        (_firstSide + _secondSide) * 2;
}