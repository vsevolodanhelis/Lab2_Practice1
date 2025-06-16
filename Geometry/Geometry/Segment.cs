namespace Geometry;

public class Segment
{
    public Point Start { get; }
    public Point End { get; }

    public Segment(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Segment other)
        {
            return Start.Equals(other.Start) && End.Equals(other.End);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }
}
