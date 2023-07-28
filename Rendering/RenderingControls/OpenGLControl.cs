using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;
using System.Windows.Forms;

namespace GeometryOpenTK.Rendering.RenderingControls
{
    public class OpenGLControl : GLControl
    {
        public OpenGLControl()
            : base(new GraphicsMode(32, 24), 2, 0, GraphicsContextFlags.Default)
        {
            MakeCurrent();
            Paint += ControlPaint;
            Dock = DockStyle.Fill;
        }

        private void ControlPaint(object sender, PaintEventArgs e)
        {
            GL.ClearColor(0.5f, 0.5f, 0.5f, 1);
            GL.Clear(
                ClearBufferMask.ColorBufferBit |
                ClearBufferMask.DepthBufferBit |
                ClearBufferMask.StencilBufferBit);

            SwapBuffers();
        }
    }
}
