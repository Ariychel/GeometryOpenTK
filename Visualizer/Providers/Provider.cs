using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Integration;
using Visualizer.Rendering.RenderingControls;
using Microsoft.Extensions.DependencyInjection;
using OpenTK;
using OpenTK.Graphics;

namespace Visualizer.Providers
{
    public class Provider
    {
        private readonly ServiceProvider _serviceProvider;

        public WindowsFormsHost OpenGLControl => new WindowsFormsHost() { Child = _serviceProvider.GetService<OpenGLControl>() };

        public Provider()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<OpenGLControl>();

            _serviceProvider = services.BuildServiceProvider();
        }
    }
}
