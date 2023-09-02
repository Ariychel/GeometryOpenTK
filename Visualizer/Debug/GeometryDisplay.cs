using Geometry.Structures;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Visualizer.Debug
{
    public static class GeometryDisplay
    {
        public static void Point(Point2d point, float size, Color color) => Point(point.X, point.Y, size, color);

        public static void Point(double x, double y, float size, Color color)
        {
            GL.PointSize(size);
            GL.Begin(BeginMode.Points);
            GL.Color3(color);
            GL.Vertex2(x, y);
            GL.End();
        }

        public static void Point(Point3d point, float size, Color color) => Point(point.X, point.Y, point.Z, size, color);

        public static void Point(double x, double y, double z, float size, Color color)
        {
            GL.PointSize(size);
            GL.Begin(BeginMode.Points);
            GL.Color3(color);
            GL.Vertex3(x, y, z);
            GL.End();
        }

        public static void Vector(Vector3d direction, float size, Color color)
        {
            Ray(new Ray(new Point3d(0, 0, 0), direction), 1, size, color);
        }

        public static void Vector(Point3d start, Vector3d direction, float size, Color color)
        {
            Ray(new Ray(start, direction), 1, size, color);
        }

        public static void Vector(Point3d start, Vector3d direction, float length, float size, Color color)
        {
            Ray(new Ray(start, direction), length, size, color);
        }

        public static void Line(Line3d line, float width, Color color)
        {
            GL.LineWidth(width);
            GL.Begin(BeginMode.Lines);
            GL.Color3(color);
            GL.Vertex3(line.Start.X, line.Start.Y, line.Start.Z);
            GL.Vertex3(line.End.X, line.End.Y, line.End.Z);
            GL.End();
        }

        public static void Triangle(Triangle triangle, Color color)
        {
            GL.Begin(BeginMode.Triangles);
            GL.Color3(color);
            GL.Vertex3(triangle.A.X, triangle.A.Y, triangle.A.Z);
            GL.Vertex3(triangle.B.X, triangle.B.Y, triangle.B.Z);
            GL.Vertex3(triangle.C.X, triangle.C.Y, triangle.C.Z);
            GL.End();
        }

        public static void Ray(Ray ray, float length, float width, Color color)
        {
            Point3d endRay = ray.Start + (length * ray.Direction);
            GL.LineWidth(width);
            GL.Begin(BeginMode.Lines);
            GL.Color3(color);
            GL.Vertex3(ray.Start.X, ray.Start.Y, ray.Start.Z);
            GL.Vertex3(endRay.X, endRay.Y, endRay.Z);
            GL.End();
        }
    }
}
