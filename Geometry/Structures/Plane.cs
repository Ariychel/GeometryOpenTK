using System.Numerics;

namespace Geometry.Structures
{
    public class Plane
    {
        public Point3f Point { get; }

        public Vector3 Normal { get; }

        public Plane(Point3f point, Vector3 normal)
        {
            Point = point;
            Normal = Vector3.Normalize(normal);
        }
    }
}
