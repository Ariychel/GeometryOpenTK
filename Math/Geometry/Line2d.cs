using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOpenTK.Math.Geometry
{
    public class Line2d
    {
        public Point2d Start { get; }

        public Point2d End { get; }

        public Line2d(Point2d start, Point2d end)
        {
            Start = start;
            End = end;
        }

    }
}
