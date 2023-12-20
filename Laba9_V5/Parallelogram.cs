namespace Laba9_V5;

public class Parallelogram : TQuadrangle
{
    private double _firstSide;
    private double _secondSide;
    private double _height;

    public Parallelogram(double firstSide, double secondSide, double height)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _height = height;
    }

    public override double Area() =>
        _firstSide * _height;

    public override double Perimeter() =>
        (_firstSide * _secondSide) * 2;
}