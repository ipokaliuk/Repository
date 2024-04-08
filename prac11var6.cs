using System;

public abstract class Shape2D
{
    public abstract double Area();
}

public class Triangle : Shape2D
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public override double Area()
    {
        return Base * Height / 2;
    }
}

public class Trapezoid : Shape2D
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }

    public Trapezoid(double base1, double base2, double height)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
    }

    public override double Area()
    {
        return (Base1 + Base2) * Height / 2;
    }
}

class Program
{
    static void Main()
    {
        var triangle = new Triangle(3, 4);
        var trapezoid = new Trapezoid(3, 4, 5);

        Console.WriteLine($"Площа трикутника: {triangle.Area()}");
        Console.WriteLine($"Площа трапеції: {trapezoid.Area()}");
    }
}