using Geometry.Structures;
using System.Drawing;
using Visualizer.Debug;

namespace Visualizer
{
    public static class LabSolver
    {
        public static void ResultRendering()
        {
            //Use Visualizer.Debug.GeometryDisplay class for rendering geometry
            //Use OpenGLViews.Camera for controlling camera

            Point3f a = new Point3f(2, 0, 0);
            Point3f b = new Point3f(0, 0, 0);
            Point3f c = new Point3f(0, 0, 2);

            Triangle tri = new Triangle(a, b, c);

            GeometryDisplay.Triangle(tri, Color.White);
        }
    }
}
