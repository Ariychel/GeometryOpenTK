using OpenTK;

namespace Geometry.Structures
{
    public class Point3d
    {
        public double X { get; }

        public double Y { get; }

        public double Z { get; }

        public Point3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3d operator *(Point3d p, Vector3d v)
        {
            return new Point3d(p.X * v.X, p.Y * v.Y, p.Z * v.Z);
        }

        public static Point3d operator +(Point3d p, Vector3d v)
        {
            return new Point3d(p.X + v.X, p.Y + v.Y, p.Z + v.Z);
        }
    }
}
