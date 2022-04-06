using NUnit.Framework;
//using FigureArea;
using System;

namespace FigureArea.Tests;

public class CalculateAreaTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateCircleArea_Radius10_Result314()
    {
        var circleArea = new CircleArea(10);
        var area = circleArea.CalculateArea();
        Assert.AreEqual(area, 314);
    }

    [Test]
    public void CalculateTriangleArea_A2_B2_C2_ResultSqrt3()
    {
        var triangleArea = new TriangleArea(2, 2, 2);
        var area = triangleArea.CalculateArea();
        Assert.AreEqual(area, Math.Sqrt(3));
    }

    [Test]
    public void IsRightTriangle_A5_B4_C3()
    {
        var triangleArea = new TriangleArea(5, 4, 3);
        Assert.AreEqual(triangleArea.IsRightTriangle(), true);
    }

    [Test]
    public void IsNotRightTriangle_A2_B2_C2()
    {
        var triangleArea = new TriangleArea(2, 2, 2);
        Assert.AreNotEqual(triangleArea.IsRightTriangle(), true);
    }

    [Test]
    public void CalculateFigureArea_Circle_Radius10_Result314()
    {
        var figure = new Figure(new CircleArea(10));
        Assert.AreEqual(figure.CalculateArea(), 314);
    }
}
