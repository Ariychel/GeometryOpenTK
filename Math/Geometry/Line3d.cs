namespace GeometryOpenTK.Math.Geometry
{
    public class Line3d
    {
        public Point3d Start { get; }

        public Point3d End { get; }

        public Line3d(Point3d start, Point3d end)
        {
            Start = start;
            End = end;
        }

    }
}
