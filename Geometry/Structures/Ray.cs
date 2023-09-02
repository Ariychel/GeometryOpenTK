using OpenTK;

namespace Geometry.Structures
{
    public class Ray
    {
        public Point3d Start { get; }

        public Vector3d Direction { get; }

        public Ray(Point3d start, Vector3d direction)
        {
            Start = start;
            Direction = direction;
        }
    }
}
