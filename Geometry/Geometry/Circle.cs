namespace Geometry;

public class Circle
{
    public double Radius { get; }
    public Point? Center { get; }

    public Circle(double radius, Point center)
    {
        Radius = radius;
        Center = center;
    }

    public Circle(double radius)
    {
        Radius = radius;
        Center = null;
    }

    public double Area => Math.PI * Radius * Radius;

    public bool? BelongsToCircle(Point point)
    {
        if (Center == null)
            return null;

        var center = Center.Value;
        var distance = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));

        return Math.Abs(distance - Radius) < 1e-10; // Using small epsilon for floating point comparison
    }
}