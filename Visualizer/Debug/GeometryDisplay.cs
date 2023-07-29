using Geometry.Structures;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Visualizer.Debug
{
    public static class GeometryDisplay
    {
        public static void Point2d(Point2d point, float size, Color color) => Point2d(point.X, point.Y, size, color);

        public static void Point2d(double x, double y, float size, Color color)
        {
            GL.PointSize(size);
            GL.Begin(BeginMode.Points);
            GL.Color3(color);
            GL.Vertex2(x, y);
            GL.End();
        }

        public static void Point3d(double x, double y, double z, float size, Color color)
        {
            GL.PointSize(size);
            GL.Begin(BeginMode.Points);
            GL.Color3(color);
            GL.Vertex3(x, y, z);
            GL.End();
        }

        public static void Line3d(Line3d line, float width, Color color)
        {
            GL.LineWidth(width);
            GL.Begin(BeginMode.Lines);
            GL.Color3(color);
            GL.Vertex3(line.Start.X, line.Start.Y, line.Start.Z);
            GL.Vertex3(line.End.X, line.End.Y, line.End.Z);
            GL.End();
        }
    }
}
