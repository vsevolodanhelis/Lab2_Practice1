using FluentAssertions;

namespace Geometry.Tests;

public class PointTests
{
    [Fact]
    public void Point_can_be_created()
    {
        var point = new Point(3, 4);

        point.X.Should().Be(3);
        point.Y.Should().Be(4);
    }

    [Fact]
    public void Point_can_be_created_with_non_integer_coordinates()
    {
        var point = new Point(-2.4, 4.5);

        point.X.Should().Be(-2.4);
        point.Y.Should().Be(4.5);
    }

    [Fact]
    public void Two_instances_of_points_are_equal_when_coordinates_are_the_same()
    {
        var point1 = new Point(2, 3);
        var point2 = new Point(2, 3);

        point1.X.Should().Be(point2.X);
        point1.Y.Should().Be(point2.Y);
        point1.Should().Be(point2);
        //which is the same as
        point1.Equals(point2).Should().BeTrue();
    }
}
