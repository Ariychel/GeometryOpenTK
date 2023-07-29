using GeometryOpenTK.Math.Geometry;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace GeometryOpenTK.OpenGLViews
{
    public class Camera
    {
        public Point3f Position { get; }

        public Point3f Target { get; }

        public Vector3 Up { get; }

        public Matrix4 ViewMatrix { get; }

        public Camera(Point3f position, Point3f target, Vector3 up)
        {
            Position = position;
            Target = target;
            Up = up;
            ViewMatrix = Matrix4.LookAt(new Vector3(Position.X, Position.Y, Position.Z), new Vector3(target.X, target.Y, target.Z), Up);
        }

        public static void SetIsoCamera(float distance, Point3f target)
        {
            if (distance < 0)
                distance = System.Math.Abs(distance);

            Camera camera = new Camera(new Point3f(distance, distance, distance), target, Vector3.UnitY);
            SetMatrix(camera.ViewMatrix);
        }

        public static void SetCamera(Point3f cameraPosition, Point3f target)
        {
            Camera camera = new Camera(cameraPosition, target, Vector3.UnitY);
            SetMatrix(camera.ViewMatrix);
        }

        private static void SetMatrix(Matrix4 matrix)
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref matrix);
        }
    }
}
