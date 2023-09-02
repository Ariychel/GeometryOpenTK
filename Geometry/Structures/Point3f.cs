using OpenTK;

namespace Geometry.Structures
{
    public class Point3f
    {
        public float X { get; }

        public float Y { get; }

        public float Z { get; }

        public Point3f(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3f operator *(Point3f p, Vector3 v)
        {
            return new Point3f(p.X * v.X, p.Y * v.Y, p.Z * v.Z);
        }
    }
}
