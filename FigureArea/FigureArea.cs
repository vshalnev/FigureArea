using System;

namespace FigureArea;

public class CircleArea : IFigureArea
{
    private const double Pi = 3.14;
    private double _radius;

    public CircleArea(double r)
    {
        _radius = r;
    }

    public double CalculateArea()
    {        
        return Pi * _radius * _radius;
    }
}

public class TriangleArea : IFigureArea
{
    private double _aSide;
    private double _bSide;
    private double _cSide;

    public TriangleArea(double a, double b, double c)
    {
        _aSide = a;
        _bSide = b;
        _cSide = c;
    }

    public double CalculateArea()
    {
        var p = (_aSide + _bSide + _cSide) / 2;
        var body = p * (p - _aSide) * (p - _bSide) * (p - _cSide);
        var area = Math.Sqrt(body);
        return area;
    }

    public bool IsRightTriangle()
    {
        if (Math.Pow(_aSide, 2) == Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2)) return true;
        if (Math.Pow(_bSide, 2) == Math.Pow(_aSide, 2) + Math.Pow(_cSide, 2)) return true;
        if (Math.Pow(_cSide, 2) == Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2)) return true;
        return false;
    } 
}

public class Figure : IFigureArea
{
    private IFigureArea _figure;

    public Figure(IFigureArea figure)
    {
        _figure = figure;
    }

    public double CalculateArea() => _figure.CalculateArea();
}