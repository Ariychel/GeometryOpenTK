using OpenTK;

namespace Geometry.Structures
{
    public class Ray
    {
        public Point3f Start { get; }

        public Vector3 Direction { get; }

        public Ray(Point3f start, Vector3 direction)
        {
            Start = start;
            Direction = direction;
        }
    }
}
