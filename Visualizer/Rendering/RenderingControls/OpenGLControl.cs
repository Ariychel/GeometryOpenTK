using Visualizer.Debug;
using Visualizer.OpenGLViews;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Windows.Forms;
using Geometry.Structures;

namespace Visualizer.Rendering.RenderingControls
{
    public class OpenGLControl : GLControl
    {
        public OpenGLControl()
            : base(GraphicsMode.Default)
        {
            MakeCurrent();
            Paint += ControlPaint;
            Dock = DockStyle.Fill;
        }

        private void ControlPaint(object sender, PaintEventArgs e)
        {
            InitControl();



            SwapBuffers();
        }

        private void InitControl()
        {
            GL.Viewport(0, 0, Width, Height);
            GL.ClearColor(0.5f, 0.5f, 0.5f, 1);
            GL.Clear(ClearBufferMask.ColorBufferBit
                    | ClearBufferMask.DepthBufferBit
                    | ClearBufferMask.StencilBufferBit);

            Matrix4 perspectiveMatrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45f), (float)Width / Height, 0.1f, 100f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspectiveMatrix);

            Camera.SetIsoCamera(15f, new Point3f(0, 0, 0));

            GeometryDisplay.Line3d(new Line3d(new Point3d(0, 0, 0), new Point3d(100, 0, 0)), 2, Color.Red); //X coord line
            GeometryDisplay.Line3d(new Line3d(new Point3d(0, 0, 0), new Point3d(0, 100, 0)), 2, Color.Green); //Y coord line
            GeometryDisplay.Line3d(new Line3d(new Point3d(0, 0, 0), new Point3d(0, 0, 100)), 2, Color.Blue); //Z coord line
        }
    }
}
