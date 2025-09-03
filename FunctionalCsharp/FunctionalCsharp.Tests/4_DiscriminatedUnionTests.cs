using NUnit.Framework;
using OneOf;

namespace FunctionalCsharp;

[TestFixture]
public class DiscriminatedUnionTests
{
    private double pi = Math.PI;

    [Test]
    public void Conditional_resolves_value()
    {
        Shape shape = new Rectangle(3, 4);
        var area = Area_Inheritance(shape);

        // var shape2 = OneOf<Circle, Rectangle, Triangle>.FromT1(new Rectangle(3, 4));
        var shape2 = new Shape2(new Rectangle(3, 4));
        area = Area_OneOf(shape2);

        Assert.That(area, Is.EqualTo(12));
    }

    private double Area_Inheritance(Shape shape)
    {
        return shape switch
        {
            Circle c    => pi * c.Radius * c.Radius,
            Rectangle r => r.Width * r.Height,
            Triangle t  => 0.5 * t.Base * t.Height,
            // compiler cant know all cases
            _ => throw new ArgumentOutOfRangeException(nameof(shape), shape, null)
        };
    }

    private double Area_OneOf(Shape2 a)
    {
        return a.Match(
            c => pi * c.Radius * c.Radius,
            r => r.Width * r.Height,
            t => 0.5 * t.Base * t.Height
        );
    }
}

// Using OneOf package
[GenerateOneOf]
public partial class Shape2 : OneOfBase<Circle, Rectangle, Triangle> { }


// Using inheritance and records - recommended by LanguageExt package
public abstract record Shape; // or interface

public record Circle(double Radius) : Shape;
public record Rectangle(double Width, double Height) : Shape;
public record Triangle(double Base, double Height) : Shape;

public record Hexagon(double Base, double Height) : Shape;