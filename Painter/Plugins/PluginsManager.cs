using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Painter.Plugins.Default;
using Plugins;

namespace Painter.Plugins
{
    public class PluginsManager
    {
        public List<IFigurePlugin> FigurePlugins = new List<IFigurePlugin>();

        public PluginsManager()
        {
            FigurePlugins.Add(new SimpleFigurePlugin());
            LoadFigurePlugins();
        }

        private void LoadFigurePlugins()
        {
            //relative path to dll-s
            foreach (string file in Directory.GetFiles(@".\..", "*.dll"))
            {
                Assembly assembly = Assembly.LoadFrom(Directory.GetCurrentDirectory() + file);
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(IFigurePlugin)))
                    {
                        IFigurePlugin figurePlugin = Activator.CreateInstance(type) as IFigurePlugin;
                        FigurePlugins.Add(figurePlugin);
                    }
                }
            }
        }
    }
}
