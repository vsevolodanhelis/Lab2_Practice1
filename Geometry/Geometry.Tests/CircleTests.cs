using FluentAssertions;

namespace Geometry.Tests;

public class CircleTests
{
    [Fact]
    public void Circle_with_center_can_be_created()
    {
        var center = new Point(3, 4);
        var circle = new Circle(5, center);

        circle.Radius.Should().Be(5);
        circle.Center.Should().Be(center);
    }

    [Fact]
    public void Circle_without_center_can_be_created()
    {
        var circle = new Circle(5);

        circle.Radius.Should().Be(5);
        circle.Center.Should().BeNull();
    }

    [Fact]
    public void Circle_with_center_returns_proper_BelongsToCircle_value()
    {
        var circle = new Circle(5, new Point(0, 0));

        circle.BelongsToCircle(new Point(0, 5)).Should().BeTrue();
        circle.BelongsToCircle(new Point(3, 4)).Should().BeTrue();
        circle.BelongsToCircle(new Point(0, 10)).Should().BeFalse();
    }

    [Fact]
    public void Circle_without_center_returns_null_for_BelongsToCircle()
    {
        var circle = new Circle(5);

        circle.BelongsToCircle(new Point(0, 5)).Should().BeNull();
        circle.BelongsToCircle(new Point(3, 4)).Should().BeNull();
        circle.BelongsToCircle(new Point(0, 10)).Should().BeNull();
    }
}