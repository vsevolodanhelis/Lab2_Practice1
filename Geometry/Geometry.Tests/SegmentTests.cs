using FluentAssertions;

namespace Geometry.Tests;

public class SegmentTests
{
    [Fact]
    public void Segment_can_be_created()
    {
        var point1 = new Point(3, 4);
        var point2 = new Point(5, 6);
        var segment = new Segment(point1, point2);

        segment.Start.Should().Be(point1);
        segment.End.Should().Be(point2);
    }

    [Fact]
    public void Two_segments_with_the_same_start_and_end_are_equal()
    {
        var segment1 = new Segment(new Point(3, 4), new Point(5, 6));
        var segment2 = new Segment(new Point(3, 4), new Point(5, 6));

        segment1.Should().Be(segment2);
        //which is the same as
        segment1.Equals(segment2).Should().BeTrue();
    }
}